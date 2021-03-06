namespace Hades.HR.UI
{
    partial class FrmProductionLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductionLine));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuViewLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.wgvWorkTeam = new Hades.Pager.WinControl.WinGridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDepartmentNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.wgvWorkSection = new Hades.Pager.WinControl.WinGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuViewTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuViewSection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteSection = new System.Windows.Forms.ToolStripMenuItem();
            this.depTree = new Hades.HR.UI.DepartmentTreeGrid();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewLine,
            this.menuAddLine,
            this.menuEditLine,
            this.menuDeleteLine});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 100);
            // 
            // menuViewLine
            // 
            this.menuViewLine.Name = "menuViewLine";
            this.menuViewLine.Size = new System.Drawing.Size(138, 24);
            this.menuViewLine.Text = "查看产线";
            // 
            // menuAddLine
            // 
            this.menuAddLine.Name = "menuAddLine";
            this.menuAddLine.Size = new System.Drawing.Size(138, 24);
            this.menuAddLine.Text = "新增产线";
            // 
            // menuEditLine
            // 
            this.menuEditLine.Name = "menuEditLine";
            this.menuEditLine.Size = new System.Drawing.Size(138, 24);
            this.menuEditLine.Text = "编辑产线";
            // 
            // menuDeleteLine
            // 
            this.menuDeleteLine.Name = "menuDeleteLine";
            this.menuDeleteLine.Size = new System.Drawing.Size(138, 24);
            this.menuDeleteLine.Text = "删除产线";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 680);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.depTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 3);
            this.groupControl1.Size = new System.Drawing.Size(294, 674);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "部门列表";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.wgvWorkTeam);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(303, 383);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(648, 294);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "班组列表";
            // 
            // wgvWorkTeam
            // 
            this.wgvWorkTeam.AppendedMenu = null;
            this.wgvWorkTeam.ColumnNameAlias = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("wgvWorkTeam.ColumnNameAlias")));
            this.wgvWorkTeam.DataSource = null;
            this.wgvWorkTeam.DisplayColumns = "";
            this.wgvWorkTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wgvWorkTeam.FixedColumns = null;
            this.wgvWorkTeam.Location = new System.Drawing.Point(2, 25);
            this.wgvWorkTeam.Name = "wgvWorkTeam";
            this.wgvWorkTeam.PrintTitle = "";
            this.wgvWorkTeam.ShowAddMenu = false;
            this.wgvWorkTeam.ShowCheckBox = false;
            this.wgvWorkTeam.ShowDeleteMenu = false;
            this.wgvWorkTeam.ShowEditMenu = false;
            this.wgvWorkTeam.ShowExportButton = true;
            this.wgvWorkTeam.Size = new System.Drawing.Size(644, 267);
            this.wgvWorkTeam.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.layoutControl1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(303, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(648, 74);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "选择部门";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDepartmentNumber);
            this.layoutControl1.Controls.Add(this.txtDepartmentName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(644, 47);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDepartmentNumber
            // 
            this.txtDepartmentNumber.Location = new System.Drawing.Point(377, 14);
            this.txtDepartmentNumber.Name = "txtDepartmentNumber";
            this.txtDepartmentNumber.Properties.ReadOnly = true;
            this.txtDepartmentNumber.Size = new System.Drawing.Size(232, 24);
            this.txtDepartmentNumber.StyleController = this.layoutControl1;
            this.txtDepartmentNumber.TabIndex = 5;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(77, 14);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Properties.ReadOnly = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(233, 24);
            this.txtDepartmentName.StyleController = this.layoutControl1;
            this.txtDepartmentName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(623, 52);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDepartmentName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(300, 28);
            this.layoutControlItem1.Text = "部门名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDepartmentNumber;
            this.layoutControlItem2.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(299, 28);
            this.layoutControlItem2.Text = "部门代码";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 18);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.wgvWorkSection);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(303, 83);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(648, 294);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "工段列表";
            // 
            // wgvWorkSection
            // 
            this.wgvWorkSection.AppendedMenu = null;
            this.wgvWorkSection.ColumnNameAlias = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("wgvWorkSection.ColumnNameAlias")));
            this.wgvWorkSection.DataSource = null;
            this.wgvWorkSection.DisplayColumns = "";
            this.wgvWorkSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wgvWorkSection.FixedColumns = null;
            this.wgvWorkSection.Location = new System.Drawing.Point(2, 25);
            this.wgvWorkSection.Name = "wgvWorkSection";
            this.wgvWorkSection.PrintTitle = "";
            this.wgvWorkSection.ShowAddMenu = false;
            this.wgvWorkSection.ShowCheckBox = false;
            this.wgvWorkSection.ShowDeleteMenu = false;
            this.wgvWorkSection.ShowEditMenu = false;
            this.wgvWorkSection.ShowExportButton = true;
            this.wgvWorkSection.Size = new System.Drawing.Size(644, 267);
            this.wgvWorkSection.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewTeam,
            this.menuAddTeam,
            this.menuEditTeam,
            this.menuDeleteTeam});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 100);
            // 
            // menuViewTeam
            // 
            this.menuViewTeam.Name = "menuViewTeam";
            this.menuViewTeam.Size = new System.Drawing.Size(138, 24);
            this.menuViewTeam.Text = "查看班组";
            this.menuViewTeam.Click += new System.EventHandler(this.menuViewTeam_Click);
            // 
            // menuAddTeam
            // 
            this.menuAddTeam.Name = "menuAddTeam";
            this.menuAddTeam.Size = new System.Drawing.Size(138, 24);
            this.menuAddTeam.Text = "新增班组";
            this.menuAddTeam.Click += new System.EventHandler(this.menuAddTeam_Click);
            // 
            // menuEditTeam
            // 
            this.menuEditTeam.Name = "menuEditTeam";
            this.menuEditTeam.Size = new System.Drawing.Size(138, 24);
            this.menuEditTeam.Text = "编辑班组";
            this.menuEditTeam.Click += new System.EventHandler(this.menuEditTeam_Click);
            // 
            // menuDeleteTeam
            // 
            this.menuDeleteTeam.Name = "menuDeleteTeam";
            this.menuDeleteTeam.Size = new System.Drawing.Size(138, 24);
            this.menuDeleteTeam.Text = "删除班组";
            this.menuDeleteTeam.Click += new System.EventHandler(this.menuDeleteTeam_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewSection,
            this.menuAddSection,
            this.menuEditSection,
            this.menuDeleteSection});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(176, 128);
            // 
            // menuViewSection
            // 
            this.menuViewSection.Name = "menuViewSection";
            this.menuViewSection.Size = new System.Drawing.Size(175, 24);
            this.menuViewSection.Text = "查看工段";
            this.menuViewSection.Click += new System.EventHandler(this.menuViewSection_Click);
            // 
            // menuAddSection
            // 
            this.menuAddSection.Name = "menuAddSection";
            this.menuAddSection.Size = new System.Drawing.Size(175, 24);
            this.menuAddSection.Text = "新增工段";
            this.menuAddSection.Click += new System.EventHandler(this.menuAddSection_Click);
            // 
            // menuEditSection
            // 
            this.menuEditSection.Name = "menuEditSection";
            this.menuEditSection.Size = new System.Drawing.Size(175, 24);
            this.menuEditSection.Text = "编辑工段";
            this.menuEditSection.Click += new System.EventHandler(this.menuEditSection_Click);
            // 
            // menuDeleteSection
            // 
            this.menuDeleteSection.Name = "menuDeleteSection";
            this.menuDeleteSection.Size = new System.Drawing.Size(175, 24);
            this.menuDeleteSection.Text = "删除工段";
            this.menuDeleteSection.Visible = false;
            this.menuDeleteSection.Click += new System.EventHandler(this.menuDeleteSection_Click);
            // 
            // depTree
            // 
            this.depTree.DataSource = null;
            this.depTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depTree.EnableFocusCellStyle = true;
            this.depTree.Location = new System.Drawing.Point(2, 25);
            this.depTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.depTree.Name = "depTree";
            this.depTree.ShowContextMenu = false;
            this.depTree.ShowMenuCreate = false;
            this.depTree.ShowMenuDelete = false;
            this.depTree.ShowMenuEdit = false;
            this.depTree.ShowMenuView = false;
            this.depTree.ShowNameOnly = true;
            this.depTree.Size = new System.Drawing.Size(290, 647);
            this.depTree.TabIndex = 0;
            this.depTree.DepartmentSelect += new System.EventHandler(this.depTree_DepartmentSelect);
            // 
            // FrmProductionLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmProductionLine";
            this.Text = "班组管理";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DepartmentTreeGrid depTree;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Pager.WinControl.WinGridView wgvWorkTeam;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtDepartmentName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtDepartmentNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuViewLine;
        private System.Windows.Forms.ToolStripMenuItem menuAddLine;
        private System.Windows.Forms.ToolStripMenuItem menuEditLine;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteLine;
        private System.Windows.Forms.ToolStripMenuItem menuViewTeam;
        private System.Windows.Forms.ToolStripMenuItem menuAddTeam;
        private System.Windows.Forms.ToolStripMenuItem menuEditTeam;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteTeam;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem menuViewSection;
        private System.Windows.Forms.ToolStripMenuItem menuAddSection;
        private System.Windows.Forms.ToolStripMenuItem menuEditSection;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteSection;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Pager.WinControl.WinGridView wgvWorkSection;
    }
}