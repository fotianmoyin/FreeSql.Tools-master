using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using FreeSql.DatabaseModel;
using FreeSqlTools.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSqlTools
{
    public partial class FrmBatch : DevComponents.DotNetBar.Office2007Form
    {
        private Node _node;
        private FrmLoading _frmLoading = null;
        private List<FileInfo> _fileInfos = new List<FileInfo>();
        private List<DbTableInfo> _dbTableInfos = new List<DbTableInfo>();

        public FrmBatch(Node node)
        {
            this.EnableGlass = false;
            InitializeComponent();
            _node = node;                   
        }

        private void FrmBatch_Load(object sender, EventArgs e)
        {
            //ThreadPool.QueueUserWorkItem(x => {
            //    _frmLoading = new FrmLoading();
            //    _frmLoading.ShowDialog();
            //});
            lbServer.Text = _node.Parent.Text;
            lbDatabase.Text = _node.Text;
            LoadTableList();
            loadTemplates();
            Properties.Settings.Default.Reload();
            //this.Invoke((Action)delegate { _frmLoading.Close(); });
        }

        private void loadTemplates()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Templates");
            string[] dir = Directory.GetDirectories(path);
            DirectoryInfo fdir = new DirectoryInfo(path);
            FileInfo[] file = fdir.GetFiles("*.tpl");
            if (file.Length != 0 || dir.Length != 0)
            {
                foreach (FileInfo f in file)
                {
                    _fileInfos.Add(f);
                    listBoxTemplates.Items.Add(f.Name);
                }
            }
        }

        private void LoadTableList()
        {
            _dbTableInfos = DatabaseHelper.GetTablesByDatabase(_node.Parent.DataKey, _node.Text);
            listBoxLeft.DataSource = _dbTableInfos.Select(a => a.Name).ToArray();
        }

        private void command_all_Executed(object sender, EventArgs e)
        {
            listBoxRight.Items.Clear();
            foreach (var m in (string[])listBoxLeft.DataSource)
                listBoxRight.Items.Add(m);
        }

        private void command_unall_Executed(object sender, EventArgs e)
        {
            listBoxRight.Items.Clear();
        }

        private void command_select_Executed(object sender, EventArgs e)
        {
            var item = listBoxLeft.SelectedItem;
            if (item != null)
            {
                if (!listBoxRight.Items.Cast<string>().Any(a => a == item.ToString()))
                {
                    listBoxRight.Items.Add(item);
                }
            }
        }

        private void command_unselect_Executed(object sender, EventArgs e)
        {
            var item = listBoxRight.SelectedItem;
            if (item != null)
            {
                listBoxRight.Items.Remove(item);
            }
        }

        private void command_openFileDialog_Executed(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void command_export_Executed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            if (listBoxRight.Items.Count == 0)
            {
                MessageBoxEx.Show("请选择表");
                return;
            }
            if (string.IsNullOrEmpty(txtNamespace.Text))
            {
                MessageBoxEx.Show("命名空间不能为空");
                return;
            }
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBoxEx.Show("请选择导出路径");
                return;
            }
            if (listBoxTemplates.CheckedItems.Count == 0)
            {
                MessageBoxEx.Show("请选择生成模板");
                return;
            }
            var templates = listBoxTemplates.CheckedItems.Cast<ListBoxItem>().Select(a => a.Text).ToArray();
            var taskBuild = new TaskBuild()
            {
                Fsql = DatabaseHelper.GetFreeSql(_node.DataKey),
                DbName = _node.Text,
                FileName = txtFile.Text,
                GeneratePath = txtFolder.Text,
                NamespaceName = txtNamespace.Text,
                RemoveStr = txtRemoveStr.Text,
                OptionsEntity01 = chkAllFirstToUpper.Checked,
                OptionsEntity02 = chkOnlyFirstToUpper.Checked,
                OptionsEntity03 = chkToLower.Checked,
                OptionsEntity04 = chkUnderlineToCamel.Checked,
                Templates = templates
            };
            var tables = listBoxRight.Items.Cast<string>().ToArray();
            var tableInfos = _dbTableInfos.Where(a => tables.Contains(a.Name)).ToList();
            FrmLoading frmLoading = null;
            ThreadPool.QueueUserWorkItem(new WaitCallback(a =>
            {
                this.Invoke((Action)delegate ()
                {
                    frmLoading = new FrmLoading("正在生成中，请稍后.....");
                    frmLoading.ShowDialog();
                });
            }));
            await new CodeGenerate().Setup(taskBuild, tableInfos);
            this.Invoke((Action)delegate () { frmLoading?.Close(); });
        }
    }
}
