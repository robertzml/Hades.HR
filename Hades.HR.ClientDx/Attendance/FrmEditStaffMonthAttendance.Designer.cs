namespace Hades.HR.UI
{
    partial class FrmEditStaffMonthAttendance
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
            this.txtMonth = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcAttendance = new DevExpress.XtraGrid.GridControl();
            this.bsAttendance = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAttendance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttendanceDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnualLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSickLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasualLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInjuryLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarriageLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaternityLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuneralLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbsentLeave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalOvertime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeekendOvertime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHolidayOvertime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoonShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNightShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtherNoon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtherNight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(683, 397);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(782, 397);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(596, 397);
            this.btnAdd.Visible = false;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Location = new System.Drawing.Point(12, 392);
            this.dataNavigator1.Size = new System.Drawing.Size(191, 30);
            // 
            // picPrint
            // 
            this.picPrint.Location = new System.Drawing.Point(202, 394);
            this.picPrint.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(869, 69);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "������Ϣ";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.txtDepartment);
            this.layoutControl2.Controls.Add(this.txtMonth);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 25);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(865, 42);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(408, 14);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(422, 24);
            this.txtDepartment.StyleController = this.layoutControl2;
            this.txtDepartment.TabIndex = 5;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(47, 14);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Properties.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(324, 24);
            this.txtMonth.StyleController = this.layoutControl2;
            this.txtMonth.TabIndex = 4;
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(844, 52);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMonth;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(361, 28);
            this.layoutControlItem1.Text = "�¶�";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(30, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDepartment;
            this.layoutControlItem2.Location = new System.Drawing.Point(361, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(459, 28);
            this.layoutControlItem2.Text = "����";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 18);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgcAttendance);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(869, 303);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "������Ϣ";
            // 
            // dgcAttendance
            // 
            this.dgcAttendance.DataSource = this.bsAttendance;
            this.dgcAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcAttendance.Location = new System.Drawing.Point(2, 25);
            this.dgcAttendance.MainView = this.dgvAttendance;
            this.dgcAttendance.Name = "dgcAttendance";
            this.dgcAttendance.Size = new System.Drawing.Size(865, 276);
            this.dgcAttendance.TabIndex = 0;
            this.dgcAttendance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvAttendance});
            // 
            // bsAttendance
            // 
            this.bsAttendance.DataSource = typeof(Hades.HR.Entity.StaffMonthAttendanceInfo);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvAttendance.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgvAttendance.ColumnPanelRowHeight = 40;
            this.dgvAttendance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colYear,
            this.colMonth,
            this.colStaffId,
            this.colAttendanceDays,
            this.colAnnualLeave,
            this.colSickLeave,
            this.colCasualLeave,
            this.colInjuryLeave,
            this.colMarriageLeave,
            this.colMaternityLeave,
            this.colFuneralLeave,
            this.colAbsentLeave,
            this.colNormalOvertime,
            this.colWeekendOvertime,
            this.colHolidayOvertime,
            this.colNoonShift,
            this.colNightShift,
            this.colOtherNoon,
            this.colOtherNight,
            this.colRemark});
            this.dgvAttendance.GridControl = this.dgcAttendance;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvAttendance.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvAttendance.OptionsCustomization.AllowFilter = false;
            this.dgvAttendance.OptionsCustomization.AllowGroup = false;
            this.dgvAttendance.OptionsCustomization.AllowQuickHideColumns = false;
            this.dgvAttendance.OptionsCustomization.AllowSort = false;
            this.dgvAttendance.OptionsView.ShowGroupPanel = false;
            this.dgvAttendance.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvAttendance_CustomColumnDisplayText);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            // 
            // colMonth
            // 
            this.colMonth.FieldName = "Month";
            this.colMonth.Name = "colMonth";
            // 
            // colStaffId
            // 
            this.colStaffId.Caption = "ְԱ����";
            this.colStaffId.FieldName = "StaffId";
            this.colStaffId.Name = "colStaffId";
            this.colStaffId.OptionsColumn.AllowEdit = false;
            this.colStaffId.Visible = true;
            this.colStaffId.VisibleIndex = 0;
            // 
            // colAttendanceDays
            // 
            this.colAttendanceDays.Caption = "��������";
            this.colAttendanceDays.FieldName = "AttendanceDays";
            this.colAttendanceDays.Name = "colAttendanceDays";
            this.colAttendanceDays.Visible = true;
            this.colAttendanceDays.VisibleIndex = 1;
            // 
            // colAnnualLeave
            // 
            this.colAnnualLeave.Caption = "�������";
            this.colAnnualLeave.FieldName = "AnnualLeave";
            this.colAnnualLeave.Name = "colAnnualLeave";
            this.colAnnualLeave.Visible = true;
            this.colAnnualLeave.VisibleIndex = 2;
            // 
            // colSickLeave
            // 
            this.colSickLeave.Caption = "��������";
            this.colSickLeave.FieldName = "SickLeave";
            this.colSickLeave.Name = "colSickLeave";
            this.colSickLeave.Visible = true;
            this.colSickLeave.VisibleIndex = 3;
            // 
            // colCasualLeave
            // 
            this.colCasualLeave.Caption = "�¼�����";
            this.colCasualLeave.FieldName = "CasualLeave";
            this.colCasualLeave.Name = "colCasualLeave";
            this.colCasualLeave.Visible = true;
            this.colCasualLeave.VisibleIndex = 4;
            // 
            // colInjuryLeave
            // 
            this.colInjuryLeave.Caption = "��������";
            this.colInjuryLeave.FieldName = "InjuryLeave";
            this.colInjuryLeave.Name = "colInjuryLeave";
            this.colInjuryLeave.Visible = true;
            this.colInjuryLeave.VisibleIndex = 5;
            // 
            // colMarriageLeave
            // 
            this.colMarriageLeave.Caption = "�������";
            this.colMarriageLeave.FieldName = "MarriageLeave";
            this.colMarriageLeave.Name = "colMarriageLeave";
            this.colMarriageLeave.Visible = true;
            this.colMarriageLeave.VisibleIndex = 6;
            // 
            // colMaternityLeave
            // 
            this.colMaternityLeave.Caption = "��������";
            this.colMaternityLeave.FieldName = "MaternityLeave";
            this.colMaternityLeave.Name = "colMaternityLeave";
            this.colMaternityLeave.Visible = true;
            this.colMaternityLeave.VisibleIndex = 7;
            // 
            // colFuneralLeave
            // 
            this.colFuneralLeave.Caption = "ɥ������";
            this.colFuneralLeave.FieldName = "FuneralLeave";
            this.colFuneralLeave.Name = "colFuneralLeave";
            this.colFuneralLeave.Visible = true;
            this.colFuneralLeave.VisibleIndex = 8;
            // 
            // colAbsentLeave
            // 
            this.colAbsentLeave.Caption = "��������";
            this.colAbsentLeave.FieldName = "AbsentLeave";
            this.colAbsentLeave.Name = "colAbsentLeave";
            this.colAbsentLeave.Visible = true;
            this.colAbsentLeave.VisibleIndex = 9;
            // 
            // colNormalOvertime
            // 
            this.colNormalOvertime.Caption = "ƽʱ�Ӱ๤ʱ";
            this.colNormalOvertime.FieldName = "NormalOvertime";
            this.colNormalOvertime.Name = "colNormalOvertime";
            this.colNormalOvertime.Visible = true;
            this.colNormalOvertime.VisibleIndex = 10;
            // 
            // colWeekendOvertime
            // 
            this.colWeekendOvertime.Caption = "��ĩ�Ӱ๤ʱ";
            this.colWeekendOvertime.FieldName = "WeekendOvertime";
            this.colWeekendOvertime.Name = "colWeekendOvertime";
            this.colWeekendOvertime.Visible = true;
            this.colWeekendOvertime.VisibleIndex = 11;
            // 
            // colHolidayOvertime
            // 
            this.colHolidayOvertime.Caption = "�ڼ��ռӰ๤ʱ";
            this.colHolidayOvertime.FieldName = "HolidayOvertime";
            this.colHolidayOvertime.Name = "colHolidayOvertime";
            this.colHolidayOvertime.Visible = true;
            this.colHolidayOvertime.VisibleIndex = 12;
            // 
            // colNoonShift
            // 
            this.colNoonShift.Caption = "�а�����";
            this.colNoonShift.FieldName = "NoonShift";
            this.colNoonShift.Name = "colNoonShift";
            this.colNoonShift.Visible = true;
            this.colNoonShift.VisibleIndex = 13;
            // 
            // colNightShift
            // 
            this.colNightShift.Caption = "ҹ������";
            this.colNightShift.FieldName = "NightShift";
            this.colNightShift.Name = "colNightShift";
            this.colNightShift.Visible = true;
            this.colNightShift.VisibleIndex = 14;
            // 
            // colOtherNoon
            // 
            this.colOtherNoon.Caption = "�����а�����";
            this.colOtherNoon.FieldName = "OtherNoon";
            this.colOtherNoon.Name = "colOtherNoon";
            this.colOtherNoon.Visible = true;
            this.colOtherNoon.VisibleIndex = 15;
            // 
            // colOtherNight
            // 
            this.colOtherNight.Caption = "����ҹ������";
            this.colOtherNight.FieldName = "OtherNight";
            this.colOtherNight.Name = "colOtherNight";
            this.colOtherNight.Visible = true;
            this.colOtherNight.VisibleIndex = 16;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "��ע";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 17;
            // 
            // FrmEditStaffMonthAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 432);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmEditStaffMonthAttendance";
            this.Text = "StaffMonthAttendance";
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dataNavigator1, 0);
            this.Controls.SetChildIndex(this.picPrint, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit txtDepartment;
        private DevExpress.XtraEditors.TextEdit txtMonth;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgcAttendance;
        private System.Windows.Forms.BindingSource bsAttendance;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvAttendance;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffId;
        private DevExpress.XtraGrid.Columns.GridColumn colAttendanceDays;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnualLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colSickLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colCasualLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colInjuryLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colMarriageLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colMaternityLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colFuneralLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colAbsentLeave;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalOvertime;
        private DevExpress.XtraGrid.Columns.GridColumn colWeekendOvertime;
        private DevExpress.XtraGrid.Columns.GridColumn colHolidayOvertime;
        private DevExpress.XtraGrid.Columns.GridColumn colNoonShift;
        private DevExpress.XtraGrid.Columns.GridColumn colNightShift;
        private DevExpress.XtraGrid.Columns.GridColumn colOtherNoon;
        private DevExpress.XtraGrid.Columns.GridColumn colOtherNight;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
    }
}