using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using FreeSqlTools.Component;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSqlTools
{
    public partial class MainForm : RibbonForm
    {
        private static FrmLoading _frmLoading;
        private Dictionary<string, UCEditor> _pairs = new Dictionary<string, UCEditor>();

        public MainForm()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var process = Process.GetCurrentProcess();
            process.Kill();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => LoadDataTreeList());
            // DesktopAlert.Show("发现新版本", "\uf005", eSymbolSet.Awesome, Color.Empty, eDesktopAlertColor.DarkRed, eAlertPosition.BottomRight, 5, 0, (x) => { });
            this.WindowState = FormWindowState.Maximized;
        }

        private void treeNodes_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (e.Node.Level == 0 || e.Node.Level > 2)
                return;

            LoadDataInfo(e.Node);
        }

        private void cmdAddConn_Executed(object sender, EventArgs e)
        {
            var frm = new FrmCreateDataConnection();
            var frmResult = frm.ShowDialog();
            if (frmResult == DialogResult.OK)
                LoadDataTreeList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Task.Run(() => LoadDataTreeList());
        }

        /// <summary>
        /// 添加连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddConn_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateDataConnection();
            var frmResult = frm.ShowDialog();
            if (frmResult == DialogResult.OK)
                LoadDataTreeList();
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenConn_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            node.Nodes.Clear();
            LoadDataInfo(node);
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            node.Nodes.Clear();
        }

        /// <summary>
        /// 删除连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteConn_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            if (node != null && node.Level == 1)
            {
                if (MessageBoxEx.Show("是否删除当前选中服务器", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    node.Nodes.Clear();
                    DatabaseInfo baseInfo = new DatabaseInfo();
                    baseInfo.Delete(Guid.Parse(node.Name));
                    treeNodes.Nodes[0].Nodes.Remove(node);
                }
            }
            else
            {
                MessageBoxEx.Show("删除节点无效", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDatabase_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            node.Nodes.Clear();
            LoadDataInfo(node);
        }

        /// <summary>
        /// 刷新数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshDatabase_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            node.Nodes.Clear();
            LoadDataInfo(node);
        }

        /// <summary>
        /// 批量生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void command_batch_Executed(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            var frm = new FrmBatch(node);
            frm.ShowDialog();
        }

        private void btnNewTemplate_Click(object sender, EventArgs e)
        {
            EditTemplates(true);
        }

        private void btnEditTemplate_Click(object sender, EventArgs e)
        {
            EditTemplates(false);
        }

        private void EditTemplates(bool fag)
        {

            string path = string.Empty;
            var form = new FrmRazorTemplates(fag);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (_pairs.ContainsKey(form.TemplatesName))
                {
                    var item = superTabControl.Tabs.Cast<SuperTabItem>()
                        .Where(a => a.Text == form.TemplatesName).FirstOrDefault();
                    superTabControl.SelectedTab = item;
                    return;
                }
                var superItem = superTabControl.CreateTab(form.TemplatesName);
                var ucEditor = new UCEditor(form.TemplatesPath);
                _pairs.Add(form.TemplatesName, ucEditor);
                superTabControl.SelectedTab = superItem;
                ucEditor.Dock = DockStyle.Fill;
                superTabControl.SelectedPanel.Controls.Add(ucEditor);
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/2881099/FreeSql/issues/new");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/2881099/FreeSql");
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/2881099/FreeSql/wiki");
        }

        private void btnBuildCode_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            var superItem = superTabControl.CreateTab($"({node.Parent.Text })-{node.Text}");
            var ucEditor = new UCGeneratedCode(node);
            superTabControl.SelectedTab = superItem;
            ucEditor.Dock = DockStyle.Fill;
            superTabControl.SelectedPanel.Controls.Add(ucEditor);
        }

        private void btnShowPre100_Click(object sender, EventArgs e)
        {
            var node = treeNodes.SelectedNode;
            var superItem = superTabControl.CreateTab($"({node.Parent.Text })-{node.Text} 查询");
            var ucEditor = new UCDataGrid(node);
            superTabControl.SelectedTab = superItem;
            ucEditor.Dock = DockStyle.Fill;
            superTabControl.SelectedPanel.Controls.Add(ucEditor);
        }

        private void superTabControl_TabItemClose(object sender, SuperTabStripTabItemCloseEventArgs e)
        {
            if (e.Tab.Text == "首页")
            {
                e.Cancel = true;
                ToastNotification.ToastBackColor = Color.Red;
                ToastNotification.ToastForeColor = Color.White;
                ToastNotification.ToastFont = new Font("微软雅黑", 15);
                ToastNotification.Show(superTabControl, "默认页不允许关闭", null, 3000, eToastGlowColor.Red, eToastPosition.TopCenter);
            }

            if (_pairs.ContainsKey(e.Tab.Text)) 
                _pairs.Remove(e.Tab.Text);

            if (_pairs.Count == 0) 
                btnSaveTemplate.Enabled = false;
        }

        private void superTabControl_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            btnSaveTemplate.Enabled = false;
            var superTab = superTabControl.SelectedTab;
            if (_pairs.TryGetValue(superTab.Text, out UCEditor uCEditor))
            {
                btnSaveTemplate.Command = uCEditor.command_save;
                btnSaveTemplate.Enabled = true;
            }
        }

        private void LoadDataTreeList()
        {
            DatabaseInfo baseInfo = new DatabaseInfo();
            treeNodes.Nodes[0].Nodes.Clear();
            List<Node> nodes = new List<Node>();
            foreach (var m in baseInfo.Databases)
            {
                //var connectionString = m.IsString ? m.ConnectionString
                //    : G.GetConnectionString(m.DataType, m.UserId, m.Pwd, m.Host, m.DbName,
                //       m.Port, m.ValidatorType);
                var node = new Node($"{m.Name}({m.DataType.ToString()})")
                {
                    Image = Properties.Resources.monitor,
                    Name = m.Id.ToString(),
                    Tag = m,
                    //TagString = connectionString,
                    DataKey = $"{m.DataType.ToString()}_{m.Id.ToString("N")}"
                };
                node.ContextMenu = buttonItem21;
                DatabaseHelper.AddFreeSql(node.DataKey, m);
                nodes.Add(node);
            }
            treeNodes.Nodes[0].Nodes.AddRange(nodes.ToArray());
        }

        private async void LoadDataInfo(Node node)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(a =>
            {
                _frmLoading = new FrmLoading();
                _frmLoading.ShowDialog();
            }));

            var res = await Task.Run(() =>
            {

                if (node.Level == 1)
                {
                    if (node.Nodes.Count >= 1)
                        return 0;
                    node.Nodes.Clear();
                    var list = DatabaseHelper.GetDatabases(node.DataKey, node.TagString);
                    var nodes = list.Select(a => new Node(a)
                    {
                        Image = Properties.Resources._base,
                        DataKey = node.DataKey,
                        ContextMenu = buttonItem22
                    }).ToArray();
                    node.Nodes.AddRange(nodes);
                }
                else if (node.Level == 2)
                {
                    node.Nodes.Clear();
                    Task.Delay(1000);
                    var list = DatabaseHelper.GetTablesByDatabase(node.DataKey, node.Text);
                    var nodes = list.Select(a => new Node(a.Name)
                    {
                        Image = Properties.Resources.application,
                        // CheckBoxVisible = true,
                        // CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox,
                        // CheckState = CheckState.Unchecked,
                        Tag = a,
                        DataKey = node.DataKey,
                        ContextMenu = buttonItem23
                    }).ToArray();
                    node.Nodes.AddRange(nodes);
                }
                return 0;
            });
            node.Expanded = true;
            this.Invoke((Action)delegate () { Thread.CurrentThread.Join(500); _frmLoading.Close(); });
        }
    }
}
