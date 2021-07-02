namespace FreeSqlTools
{
    partial class FrmCreateDataConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateDataConnection));
            this.gpDatabases = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chkCustom = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkSqlite = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkOracle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkPostgreSql = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkSqlServer = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkMySql = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnTest = new DevComponents.DotNetBar.ButtonX();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.lbTip = new System.Windows.Forms.Label();
            this.gpDatabases.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDatabases
            // 
            this.gpDatabases.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDatabases.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDatabases.Controls.Add(this.chkCustom);
            this.gpDatabases.Controls.Add(this.chkSqlite);
            this.gpDatabases.Controls.Add(this.chkOracle);
            this.gpDatabases.Controls.Add(this.chkPostgreSql);
            this.gpDatabases.Controls.Add(this.chkSqlServer);
            this.gpDatabases.Controls.Add(this.chkMySql);
            this.gpDatabases.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpDatabases.Location = new System.Drawing.Point(12, 12);
            this.gpDatabases.Name = "groupPanel1";
            this.gpDatabases.Size = new System.Drawing.Size(600, 298);
            // 
            // 
            // 
            this.gpDatabases.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDatabases.Style.BackColorGradientAngle = 90;
            this.gpDatabases.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDatabases.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDatabases.Style.BorderBottomWidth = 1;
            this.gpDatabases.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDatabases.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDatabases.Style.BorderLeftWidth = 1;
            this.gpDatabases.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDatabases.Style.BorderRightWidth = 1;
            this.gpDatabases.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDatabases.Style.BorderTopWidth = 1;
            this.gpDatabases.Style.CornerDiameter = 4;
            this.gpDatabases.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDatabases.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpDatabases.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDatabases.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpDatabases.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpDatabases.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpDatabases.TabIndex = 0;
            this.gpDatabases.Text = "选择数据库类型";
            // 
            // chkCustom
            // 
            this.chkCustom.AutoSize = true;
            this.chkCustom.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkCustom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkCustom.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkCustom.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkCustom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustom.Location = new System.Drawing.Point(336, 85);
            this.chkCustom.Name = "checkBoxX6";
            this.chkCustom.Size = new System.Drawing.Size(98, 27);
            this.chkCustom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkCustom.TabIndex = 5;
            this.chkCustom.Text = "自定义";
            // 
            // chkSqlite
            // 
            this.chkSqlite.AutoSize = true;
            this.chkSqlite.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkSqlite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSqlite.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkSqlite.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkSqlite.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSqlite.Location = new System.Drawing.Point(161, 85);
            this.chkSqlite.Name = "checkBoxX5";
            this.chkSqlite.Size = new System.Drawing.Size(98, 27);
            this.chkSqlite.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkSqlite.TabIndex = 4;
            this.chkSqlite.Text = "Sqlite";
            // 
            // chkOracle
            // 
            this.chkOracle.AutoSize = true;
            this.chkOracle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkOracle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkOracle.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkOracle.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkOracle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOracle.Location = new System.Drawing.Point(28, 85);
            this.chkOracle.Name = "checkBoxX4";
            this.chkOracle.Size = new System.Drawing.Size(98, 27);
            this.chkOracle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkOracle.TabIndex = 3;
            this.chkOracle.Text = "Oracle";
            // 
            // chkPostgreSql
            // 
            this.chkPostgreSql.AutoSize = true;
            this.chkPostgreSql.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkPostgreSql.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkPostgreSql.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkPostgreSql.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkPostgreSql.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPostgreSql.Location = new System.Drawing.Point(336, 32);
            this.chkPostgreSql.Name = "checkBoxX3";
            this.chkPostgreSql.Size = new System.Drawing.Size(141, 27);
            this.chkPostgreSql.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkPostgreSql.TabIndex = 2;
            this.chkPostgreSql.Text = "PostgreSQL";
            // 
            // chkSqlServer
            // 
            this.chkSqlServer.AutoSize = true;
            this.chkSqlServer.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkSqlServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSqlServer.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkSqlServer.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkSqlServer.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSqlServer.Location = new System.Drawing.Point(161, 32);
            this.chkSqlServer.Name = "checkBoxX2";
            this.chkSqlServer.Size = new System.Drawing.Size(131, 27);
            this.chkSqlServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkSqlServer.TabIndex = 1;
            this.chkSqlServer.Text = "SqlServer";
            // 
            // chkMySql
            // 
            this.chkMySql.AutoSize = true;
            this.chkMySql.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkMySql.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkMySql.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkMySql.Checked = true;
            this.chkMySql.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkMySql.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMySql.CheckValue = "Y";
            this.chkMySql.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMySql.Location = new System.Drawing.Point(28, 32);
            this.chkMySql.Name = "checkBoxX1";
            this.chkMySql.Size = new System.Drawing.Size(88, 27);
            this.chkMySql.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkMySql.TabIndex = 0;
            this.chkMySql.Text = "MySql";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnTest);
            this.groupPanel2.Controls.Add(this.btnLast);
            this.groupPanel2.Controls.Add(this.btnNext);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 316);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(600, 55);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTest.Location = new System.Drawing.Point(3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(133, 42);
            this.btnTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "测试连接";
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnLast
            // 
            this.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLast.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLast.Location = new System.Drawing.Point(317, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(133, 42);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "上一步";
            this.btnLast.Visible = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(456, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 42);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一步";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTip.ForeColor = System.Drawing.Color.DeepPink;
            this.lbTip.Location = new System.Drawing.Point(40, 175);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(446, 19);
            this.lbTip.TabIndex = 4;
            this.lbTip.Text = "其他数据库请使用 FreeSql.Generator 生成实体类";
            // 
            // FrmCreateDataConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 374);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.gpDatabases);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCreateDataConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择数据库类型";
            this.gpDatabases.ResumeLayout(false);
            this.gpDatabases.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpDatabases;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSqlServer;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMySql;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkPostgreSql;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkOracle;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSqlite;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnTest;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkCustom;
        private System.Windows.Forms.Label lbTip;
    }
}