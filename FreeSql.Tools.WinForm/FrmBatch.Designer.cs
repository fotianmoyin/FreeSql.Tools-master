namespace FreeSqlTools
{
    partial class FrmBatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatch));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbDatabase = new DevComponents.DotNetBar.LabelX();
            this.lbServer = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnOneToLeft = new DevComponents.DotNetBar.ButtonX();
            this.command_unselect = new DevComponents.DotNetBar.Command(this.components);
            this.btnAllToLeft = new DevComponents.DotNetBar.ButtonX();
            this.command_unall = new DevComponents.DotNetBar.Command(this.components);
            this.btnOneToRight = new DevComponents.DotNetBar.ButtonX();
            this.command_select = new DevComponents.DotNetBar.Command(this.components);
            this.btnAllToRight = new DevComponents.DotNetBar.ButtonX();
            this.command_all = new DevComponents.DotNetBar.Command(this.components);
            this.listBoxRight = new DevComponents.DotNetBar.ListBoxAdv();
            this.listBoxLeft = new DevComponents.DotNetBar.ListBoxAdv();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExport = new DevComponents.DotNetBar.ButtonX();
            this.command_export = new DevComponents.DotNetBar.Command(this.components);
            this.btnChooseFolder = new DevComponents.DotNetBar.ButtonX();
            this.command_folderBrowserDialog = new DevComponents.DotNetBar.Command(this.components);
            this.txtFolder = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listBoxTemplates = new DevComponents.DotNetBar.ListBoxAdv();
            this.txtFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.chkUnderlineToCamel = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkToLower = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkOnlyFirstToUpper = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkAllFirstToUpper = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtRemoveStr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtNamespace = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbDatabase);
            this.groupPanel1.Controls.Add(this.lbServer);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPanel1.Size = new System.Drawing.Size(688, 61);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "数据库";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbDatabase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDatabase.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDatabase.Location = new System.Drawing.Point(444, 3);
            this.lbDatabase.Name = "labelX4";
            this.lbDatabase.Size = new System.Drawing.Size(74, 26);
            this.lbDatabase.TabIndex = 3;
            this.lbDatabase.Text = "数据库：";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbServer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbServer.Location = new System.Drawing.Point(103, 3);
            this.lbServer.Name = "labelX3";
            this.lbServer.Size = new System.Drawing.Size(74, 26);
            this.lbServer.TabIndex = 2;
            this.lbServer.Text = "服务器：";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(371, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 26);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "数据库：";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(33, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(74, 26);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "服务器：";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnOneToLeft);
            this.groupPanel2.Controls.Add(this.btnAllToLeft);
            this.groupPanel2.Controls.Add(this.btnOneToRight);
            this.groupPanel2.Controls.Add(this.btnAllToRight);
            this.groupPanel2.Controls.Add(this.listBoxRight);
            this.groupPanel2.Controls.Add(this.listBoxLeft);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 61);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(688, 304);
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
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "选择表";
            // 
            // btnOneToLeft
            // 
            this.btnOneToLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOneToLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOneToLeft.Command = this.command_unselect;
            this.btnOneToLeft.Location = new System.Drawing.Point(304, 179);
            this.btnOneToLeft.Name = "buttonX4";
            this.btnOneToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnOneToLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOneToLeft.TabIndex = 5;
            this.btnOneToLeft.Text = "<";
            // 
            // command_unselect
            // 
            this.command_unselect.Name = "command_unselect";
            this.command_unselect.Executed += new System.EventHandler(this.command_unselect_Executed);
            // 
            // btnAllToLeft
            // 
            this.btnAllToLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllToLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAllToLeft.Command = this.command_unall;
            this.btnAllToLeft.Location = new System.Drawing.Point(304, 217);
            this.btnAllToLeft.Name = "buttonX3";
            this.btnAllToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAllToLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllToLeft.TabIndex = 4;
            this.btnAllToLeft.Text = "<<<";
            // 
            // command_unall
            // 
            this.command_unall.Name = "command_unall";
            this.command_unall.Executed += new System.EventHandler(this.command_unall_Executed);
            // 
            // btnOneToRight
            // 
            this.btnOneToRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOneToRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOneToRight.Command = this.command_select;
            this.btnOneToRight.Location = new System.Drawing.Point(304, 79);
            this.btnOneToRight.Name = "buttonX2";
            this.btnOneToRight.Size = new System.Drawing.Size(75, 23);
            this.btnOneToRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOneToRight.TabIndex = 3;
            this.btnOneToRight.Text = ">";
            // 
            // command_select
            // 
            this.command_select.Name = "command_select";
            this.command_select.Executed += new System.EventHandler(this.command_select_Executed);
            // 
            // btnAllToRight
            // 
            this.btnAllToRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllToRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAllToRight.Command = this.command_all;
            this.btnAllToRight.Location = new System.Drawing.Point(304, 37);
            this.btnAllToRight.Name = "buttonX1";
            this.btnAllToRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllToRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllToRight.TabIndex = 2;
            this.btnAllToRight.Text = ">>>";
            // 
            // command_all
            // 
            this.command_all.Name = "command_all";
            this.command_all.Executed += new System.EventHandler(this.command_all_Executed);
            // 
            // listBoxRight
            // 
            this.listBoxRight.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxRight.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxRight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxRight.CheckStateMember = null;
            this.listBoxRight.ContainerControlProcessDialogKey = true;
            this.listBoxRight.DragDropSupport = true;
            this.listBoxRight.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBoxRight.Location = new System.Drawing.Point(396, 3);
            this.listBoxRight.Name = "listBoxAdv2";
            this.listBoxRight.Size = new System.Drawing.Size(277, 269);
            this.listBoxRight.TabIndex = 1;
            this.listBoxRight.Text = "listBoxAdv2";
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxLeft.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxLeft.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxLeft.CheckStateMember = null;
            this.listBoxLeft.ContainerControlProcessDialogKey = true;
            this.listBoxLeft.DragDropSupport = true;
            this.listBoxLeft.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBoxLeft.Location = new System.Drawing.Point(9, 3);
            this.listBoxLeft.Name = "listBoxAdv1";
            this.listBoxLeft.Size = new System.Drawing.Size(277, 269);
            this.listBoxLeft.TabIndex = 0;
            this.listBoxLeft.Text = "listBoxAdv1";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnExport);
            this.groupPanel3.Controls.Add(this.btnChooseFolder);
            this.groupPanel3.Controls.Add(this.txtFolder);
            this.groupPanel3.Controls.Add(this.labelX8);
            this.groupPanel3.Controls.Add(this.groupPanel4);
            this.groupPanel3.Controls.Add(this.txtFile);
            this.groupPanel3.Controls.Add(this.labelX7);
            this.groupPanel3.Controls.Add(this.chkUnderlineToCamel);
            this.groupPanel3.Controls.Add(this.chkToLower);
            this.groupPanel3.Controls.Add(this.chkOnlyFirstToUpper);
            this.groupPanel3.Controls.Add(this.chkAllFirstToUpper);
            this.groupPanel3.Controls.Add(this.txtRemoveStr);
            this.groupPanel3.Controls.Add(this.labelX6);
            this.groupPanel3.Controls.Add(this.txtNamespace);
            this.groupPanel3.Controls.Add(this.labelX5);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Location = new System.Drawing.Point(0, 365);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(688, 232);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 6;
            this.groupPanel3.Text = "参数设置";
            // 
            // btnExport
            // 
            this.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExport.Command = this.command_export;
            this.btnExport.Location = new System.Drawing.Point(571, 166);
            this.btnExport.Name = "buttonX6";
            this.btnExport.Size = new System.Drawing.Size(108, 28);
            this.btnExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "导出";
            // 
            // command_export
            // 
            this.command_export.Name = "command_export";
            this.command_export.Executed += new System.EventHandler(this.command_export_Executed);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChooseFolder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChooseFolder.Command = this.command_folderBrowserDialog;
            this.btnChooseFolder.Location = new System.Drawing.Point(518, 167);
            this.btnChooseFolder.Name = "buttonX5";
            this.btnChooseFolder.Size = new System.Drawing.Size(47, 26);
            this.btnChooseFolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChooseFolder.TabIndex = 14;
            this.btnChooseFolder.Text = ".....";
            // 
            // command_folderBrowserDialog
            // 
            this.command_folderBrowserDialog.Name = "command_folderBrowserDialog";
            this.command_folderBrowserDialog.Executed += new System.EventHandler(this.command_openFileDialog_Executed);
            // 
            // txtFolder
            // 
            // 
            // 
            // 
            this.txtFolder.Border.Class = "TextBoxBorder";
            this.txtFolder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FreeSqlTools.Properties.Settings.Default, "exportPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFolder.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFolder.Location = new System.Drawing.Point(123, 167);
            this.txtFolder.Name = "textBoxX4";
            this.txtFolder.PreventEnterBeep = true;
            this.txtFolder.Size = new System.Drawing.Size(393, 26);
            this.txtFolder.TabIndex = 13;
            this.txtFolder.Text = global::FreeSqlTools.Properties.Settings.Default.exportPath;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(14, 167);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(107, 26);
            this.labelX8.TabIndex = 12;
            this.labelX8.Text = "导出文件夹：";
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.listBoxTemplates);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(374, 3);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(305, 158);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 11;
            this.groupPanel4.Text = "选择模板";
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxTemplates.BackgroundStyle.Class = "RichTextBoxBorder";
            this.listBoxTemplates.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxTemplates.CheckBoxesVisible = true;
            this.listBoxTemplates.CheckStateMember = null;
            this.listBoxTemplates.ContainerControlProcessDialogKey = true;
            this.listBoxTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTemplates.DragDropSupport = true;
            this.listBoxTemplates.Font = new System.Drawing.Font("宋体", 12F);
            this.listBoxTemplates.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBoxTemplates.Location = new System.Drawing.Point(0, 0);
            this.listBoxTemplates.Name = "listBoxAdv3";
            this.listBoxTemplates.Size = new System.Drawing.Size(299, 134);
            this.listBoxTemplates.TabIndex = 0;
            this.listBoxTemplates.Text = "listBoxAdv3";
            // 
            // txtFile
            // 
            // 
            // 
            // 
            this.txtFile.Border.Class = "TextBoxBorder";
            this.txtFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FreeSqlTools.Properties.Settings.Default, "saveFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFile.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFile.Location = new System.Drawing.Point(123, 135);
            this.txtFile.Name = "textBoxX3";
            this.txtFile.PreventEnterBeep = true;
            this.txtFile.Size = new System.Drawing.Size(245, 26);
            this.txtFile.TabIndex = 10;
            this.txtFile.Text = global::FreeSqlTools.Properties.Settings.Default.saveFile;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(14, 135);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(107, 26);
            this.labelX7.TabIndex = 9;
            this.labelX7.Text = "保存文件名：";
            // 
            // chkUnderlineToCamel
            // 
            this.chkUnderlineToCamel.AutoSize = true;
            this.chkUnderlineToCamel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkUnderlineToCamel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkUnderlineToCamel.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkUnderlineToCamel.Font = new System.Drawing.Font("宋体", 12F);
            this.chkUnderlineToCamel.Location = new System.Drawing.Point(154, 104);
            this.chkUnderlineToCamel.Name = "checkBoxX4";
            this.chkUnderlineToCamel.Size = new System.Drawing.Size(132, 23);
            this.chkUnderlineToCamel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkUnderlineToCamel.TabIndex = 8;
            this.chkUnderlineToCamel.Text = "下画线转驼峰";
            // 
            // chkToLower
            // 
            this.chkToLower.AutoSize = true;
            this.chkToLower.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkToLower.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkToLower.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkToLower.Font = new System.Drawing.Font("宋体", 12F);
            this.chkToLower.Location = new System.Drawing.Point(14, 104);
            this.chkToLower.Name = "checkBoxX3";
            this.chkToLower.Size = new System.Drawing.Size(99, 23);
            this.chkToLower.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkToLower.TabIndex = 7;
            this.chkToLower.Text = "全部小写";
            // 
            // chkOnlyFirstToUpper
            // 
            this.chkOnlyFirstToUpper.AutoSize = true;
            this.chkOnlyFirstToUpper.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkOnlyFirstToUpper.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkOnlyFirstToUpper.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkOnlyFirstToUpper.Font = new System.Drawing.Font("宋体", 12F);
            this.chkOnlyFirstToUpper.Location = new System.Drawing.Point(154, 75);
            this.chkOnlyFirstToUpper.Name = "checkBoxX2";
            this.chkOnlyFirstToUpper.Size = new System.Drawing.Size(181, 23);
            this.chkOnlyFirstToUpper.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkOnlyFirstToUpper.TabIndex = 6;
            this.chkOnlyFirstToUpper.Text = "首字母大写其他小写";
            // 
            // chkAllFirstToUpper
            // 
            this.chkAllFirstToUpper.AutoSize = true;
            this.chkAllFirstToUpper.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkAllFirstToUpper.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAllFirstToUpper.CheckSignSize = new System.Drawing.Size(18, 18);
            this.chkAllFirstToUpper.Font = new System.Drawing.Font("宋体", 12F);
            this.chkAllFirstToUpper.Location = new System.Drawing.Point(14, 75);
            this.chkAllFirstToUpper.Name = "checkBoxX1";
            this.chkAllFirstToUpper.Size = new System.Drawing.Size(115, 23);
            this.chkAllFirstToUpper.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAllFirstToUpper.TabIndex = 5;
            this.chkAllFirstToUpper.Text = "首字母大写";
            // 
            // txtRemoveStr
            // 
            // 
            // 
            // 
            this.txtRemoveStr.Border.Class = "TextBoxBorder";
            this.txtRemoveStr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemoveStr.Font = new System.Drawing.Font("宋体", 12F);
            this.txtRemoveStr.Location = new System.Drawing.Point(133, 42);
            this.txtRemoveStr.Name = "textBoxX2";
            this.txtRemoveStr.PreventEnterBeep = true;
            this.txtRemoveStr.Size = new System.Drawing.Size(92, 26);
            this.txtRemoveStr.TabIndex = 4;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(14, 42);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(123, 26);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "去掉表中字符：";
            // 
            // txtNamespace
            // 
            // 
            // 
            // 
            this.txtNamespace.Border.Class = "TextBoxBorder";
            this.txtNamespace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamespace.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FreeSqlTools.Properties.Settings.Default, "namespaceName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNamespace.Font = new System.Drawing.Font("宋体", 12F);
            this.txtNamespace.Location = new System.Drawing.Point(100, 9);
            this.txtNamespace.Name = "textBoxX1";
            this.txtNamespace.PreventEnterBeep = true;
            this.txtNamespace.Size = new System.Drawing.Size(268, 26);
            this.txtNamespace.TabIndex = 2;
            this.txtNamespace.Text = global::FreeSqlTools.Properties.Settings.Default.namespaceName;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(14, 9);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(90, 26);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "命名空间：";
            // 
            // FrmBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 597);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量生成";
            this.Load += new System.EventHandler(this.FrmBatch_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.groupPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lbDatabase;
        private DevComponents.DotNetBar.LabelX lbServer;
        private DevComponents.DotNetBar.ListBoxAdv listBoxRight;
        private DevComponents.DotNetBar.ListBoxAdv listBoxLeft;
        private DevComponents.DotNetBar.ButtonX btnOneToLeft;
        private DevComponents.DotNetBar.ButtonX btnAllToLeft;
        private DevComponents.DotNetBar.ButtonX btnOneToRight;
        private DevComponents.DotNetBar.ButtonX btnAllToRight;
        private DevComponents.DotNetBar.Command command_unall;
        private DevComponents.DotNetBar.Command command_select;
        private DevComponents.DotNetBar.Command command_unselect;
        private DevComponents.DotNetBar.Command command_all;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemoveStr;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNamespace;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkOnlyFirstToUpper;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAllFirstToUpper;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUnderlineToCamel;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkToLower;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFile;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFolder;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnChooseFolder;
        private DevComponents.DotNetBar.ButtonX btnExport;
        private DevComponents.DotNetBar.Command command_folderBrowserDialog;
        private DevComponents.DotNetBar.Command command_export;
        private DevComponents.DotNetBar.ListBoxAdv listBoxTemplates;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}