namespace Hades.HR.UI
{
    partial class FrmStaffMonthAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaffMonthAttendance));
            this.winGridViewPager1 = new Hades.Pager.WinControl.WinGridViewPager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.dpMonth = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.depTree = new Hades.HR.UI.DepartmentTreeGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // winGridViewPager1
            // 
            this.winGridViewPager1.AppendedMenu = null;
            this.winGridViewPager1.ColumnNameAlias = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("winGridViewPager1.ColumnNameAlias")));
            this.winGridViewPager1.DataSource = null;
            this.winGridViewPager1.DisplayColumns = "";
            this.winGridViewPager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridViewPager1.FixedColumns = null;
            this.winGridViewPager1.Location = new System.Drawing.Point(2, 25);
            this.winGridViewPager1.MinimumSize = new System.Drawing.Size(540, 0);
            this.winGridViewPager1.Name = "winGridViewPager1";
            this.winGridViewPager1.PrintTitle = "";
            this.winGridViewPager1.ShowAddMenu = false;
            this.winGridViewPager1.ShowCheckBox = false;
            this.winGridViewPager1.ShowDeleteMenu = false;
            this.winGridViewPager1.ShowEditMenu = false;
            this.winGridViewPager1.ShowExportButton = true;
            this.winGridViewPager1.Size = new System.Drawing.Size(794, 527);
            this.winGridViewPager1.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 680);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.depTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(194, 674);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "部门列表";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(203, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(798, 114);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "操作";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnEdit);
            this.layoutControl2.Controls.Add(this.dpMonth);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 25);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(794, 87);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(470, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(310, 27);
            this.btnEdit.StyleController = this.layoutControl2;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "编辑月考勤记录";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dpMonth
            // 
            this.dpMonth.EditValue = null;
            this.dpMonth.Location = new System.Drawing.Point(77, 14);
            this.dpMonth.Name = "dpMonth";
            this.dpMonth.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpMonth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpMonth.Properties.DisplayFormat.FormatString = "yyyy-MM";
            this.dpMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dpMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpMonth.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dpMonth.Properties.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)(((DevExpress.XtraEditors.VistaCalendarViewStyle.YearView | DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView)));
            this.dpMonth.Size = new System.Drawing.Size(389, 24);
            this.dpMonth.StyleController = this.layoutControl2;
            this.dpMonth.TabIndex = 4;
            this.dpMonth.EditValueChanged += new System.EventHandler(this.dpMonth_EditValueChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(794, 87);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dpMonth;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(456, 63);
            this.layoutControlItem1.Text = "月份选择";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(456, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 63);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.winGridViewPager1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 123);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(798, 554);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "考勤记录";
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
            this.depTree.Size = new System.Drawing.Size(190, 647);
            this.depTree.TabIndex = 0;
            this.depTree.DepartmentSelect += new System.EventHandler(this.depTree_DepartmentSelect);
            // 
            // FrmStaffMonthAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmStaffMonthAttendance";
            this.Text = "职员月考勤";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Hades.Pager.WinControl.WinGridViewPager winGridViewPager1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DepartmentTreeGrid depTree;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.DateEdit dpMonth;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}