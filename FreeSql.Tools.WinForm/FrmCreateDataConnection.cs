using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using FreeSqlTools.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSqlTools
{
    public partial class FrmCreateDataConnection : DevComponents.DotNetBar.OfficeForm
    {
        private UserControlBase _userControl = null;
        private Control[] _controls;

        public FrmCreateDataConnection()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "保存")
            {
                _userControl?.SaveDataConnection();
                MessageBoxEx.Show("保存成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                gpDatabases.Text = "配置数据库连接";
                _controls = gpDatabases.Controls.Cast<Control>().Where(a => (a is CheckBoxX checkBox)).ToArray();
                gpDatabases.Controls.Clear();
                var checkbox = _controls.Where(a => (a is CheckBoxX checkBox) && checkBox.Checked).FirstOrDefault();
                if (checkbox == null) return;
                switch (checkbox.Text)
                {
                    case "MySql": _userControl = new UcMysql(); break;
                    case "SqlServer": _userControl = new UcSqlServer(); break;
                    case "PostgreSQL": _userControl = new UcPostgreSQL(); break;
                    case "Oracle": _userControl = new UcOracle(); break;
                    case "Sqlite": _userControl = new UcSqlite(); break;
                    case "自定义": _userControl = new UCConnection(); break;
                }
                _userControl.BackColor = Color.Transparent;
                _userControl.Dock = DockStyle.Fill;
                gpDatabases.Controls.Add(_userControl);
                btnLast.Visible = true;
                btnTest.Visible = true;
                btnNext.Text = "保存";
                lbTip.Visible = false;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            gpDatabases.Controls.Clear();
            gpDatabases.Controls.AddRange(_controls);
            btnLast.Visible = false;
            btnTest.Visible = false;
            btnNext.Text = "下一步";
            lbTip.Visible = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            _userControl?.TestDataConnection();
        }
    }
}
