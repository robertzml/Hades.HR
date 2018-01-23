using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using Hades.Pager.Entity;
using Hades.Dictionary;
using Hades.Framework.BaseUI;
using Hades.Framework.Commons;
using Hades.Framework.ControlUtil;

using Hades.Framework.ControlUtil.Facade;
using Hades.HR.Facade;
using Hades.HR.Entity;

namespace Hades.HR.UI
{
    /// <summary>
    /// StaffMonthAttendance
    /// </summary>	
    public partial class FrmStaffMonthAttendance : BaseDock
    {
        #region Field
        /// <summary>
        /// 高级查询条件语句对象
        /// </summary>
        private SearchCondition advanceCondition;

        /// <summary>
        /// 缓存部门列表
        /// </summary>
        private List<DepartmentInfo> departmentList;
        #endregion //Field

        #region Constructor
        public FrmStaffMonthAttendance()
        {
            InitializeComponent();

            InitDictItem();

            this.winGridViewPager1.OnPageChanged += new EventHandler(winGridViewPager1_OnPageChanged);
            this.winGridViewPager1.OnStartExport += new EventHandler(winGridViewPager1_OnStartExport);
            this.winGridViewPager1.OnEditSelected += new EventHandler(winGridViewPager1_OnEditSelected);
            this.winGridViewPager1.OnAddNew += new EventHandler(winGridViewPager1_OnAddNew);
            this.winGridViewPager1.OnDeleteSelected += new EventHandler(winGridViewPager1_OnDeleteSelected);
            this.winGridViewPager1.OnRefresh += new EventHandler(winGridViewPager1_OnRefresh);
            this.winGridViewPager1.AppendedMenu = this.contextMenuStrip1;
            this.winGridViewPager1.ShowLineNumber = true;
            this.winGridViewPager1.BestFitColumnWith = false;//是否设置为自动调整宽度，false为不设置
			this.winGridViewPager1.gridView1.DataSourceChanged +=new EventHandler(gridView1_DataSourceChanged);
            this.winGridViewPager1.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView1_CustomColumnDisplayText);
            this.winGridViewPager1.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(gridView1_RowCellStyle);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化字典列表内容
        /// </summary>
        private void InitDictItem()
        {
            //初始化代码
        }

        /// <summary>
        /// 根据查询条件构造查询语句
        /// </summary> 
        private string GetConditionSql()
        {
            //如果存在高级查询对象信息，则使用高级查询条件，否则使用主表条件查询
            SearchCondition condition = advanceCondition;
            if (condition == null)
            {
                condition = new SearchCondition();
                //condition.AddCondition("StaffId", this.txtStaffId.Text.Trim(), SqlOperator.Like);
            }
            string where = condition.BuildConditionSql().Replace("Where", "");
            return where;
        }

        /// <summary>
        /// 绑定列表数据
        /// </summary>
        private void BindData()
        {
            //entity
            this.winGridViewPager1.DisplayColumns = "StaffId,DepartmentId,AttendanceDays,AnnualLeave,SickLeave,CasualLeave,InjuryLeave,MarriageLeave,MaternityLeave,FuneralLeave,AbsentLeave,NormalOvertime,WeekendOvertime,HolidayOvertime,NoonShift,NightShift,OtherNoon,OtherNight,Remark";
            this.winGridViewPager1.ColumnNameAlias = CallerFactory<IStaffMonthAttendanceService>.Instance.GetColumnNameAlias();//字段列显示名称转义
                     

            string where = GetConditionSql();
            PagerInfo pagerInfo = this.winGridViewPager1.PagerInfo;
            List<StaffMonthAttendanceInfo> list = CallerFactory<IStaffMonthAttendanceService>.Instance.FindWithPager(where, ref pagerInfo);
            this.winGridViewPager1.PagerInfo.RecordCount = pagerInfo.RecordCount;
            this.winGridViewPager1.DataSource = new Hades.Pager.WinControl.SortableBindingList<StaffMonthAttendanceInfo>(list);
            this.winGridViewPager1.PrintTitle = "StaffMonthAttendance报表";
        }

        #endregion //Function

        #region Method
        /// <summary>
        /// 编写初始化窗体的实现，可以用于刷新
        /// </summary>
        public override void FormOnLoad()
        {
            this.departmentList = CallerFactory<IDepartmentService>.Instance.Find("Deleted = 0 AND Type > 4");
            this.depTree.Init(3);

            BindData();
        }
        #endregion //Method

        #region Event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dpMonth.EditValue == null)
            {
                MessageDxUtil.ShowWarning("请选择考勤月份");
                return;
            }

            var dep = this.depTree.GetSelectedObject();
            if (dep == null)
            {
                MessageDxUtil.ShowWarning("请选择部门");
                return;
            }
            if (dep.Type != (int)DepartmentType.Department)
            {
                MessageDxUtil.ShowWarning("请选择部门");
                return;
            }

            FrmEditStaffMonthAttendance frm = new FrmEditStaffMonthAttendance(this.dpMonth.DateTime.Year, this.dpMonth.DateTime.Month, dep.Id);
            frm.InitFunction(LoginUserInfo, FunctionDict);//给子窗体赋值用户权限信息
            frm.ShowDialog();
        }
        #endregion //Event

        #region System
        void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.FieldName == "OrderStatus")
            //{
            //    string status = this.winGridViewPager1.gridView1.GetRowCellValue(e.RowHandle, "OrderStatus").ToString();
            //    Color color = Color.White;
            //    if (status == "已审核")
            //    {
            //        e.Appearance.BackColor = Color.Red;
            //        e.Appearance.BackColor2 = Color.LightCyan;
            //    }
            //}
        }
        void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
        	string columnName = e.Column.FieldName;
            if (e.Column.ColumnType == typeof(DateTime))
            {   
                if (e.Value != null)
                {
                    if (e.Value == DBNull.Value || Convert.ToDateTime(e.Value) <= Convert.ToDateTime("1900-1-1"))
                    {
                        e.DisplayText = "";
                    }
                    else
                    {
                        e.DisplayText = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd HH:mm");//yyyy-MM-dd
                    }
                }
            }
            //else if (columnName == "Age")
            //{
            //    e.DisplayText = string.Format("{0}岁", e.Value);
            //}
            //else if (columnName == "ReceivedMoney")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = e.Value.ToString().ToDecimal().ToString("C");
            //    }
            //}
        }
        
        /// <summary>
        /// 绑定数据后，分配各列的宽度
        /// </summary>
        private void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.winGridViewPager1.gridView1.Columns.Count > 0 && this.winGridViewPager1.gridView1.RowCount > 0)
            {
                //统一设置100宽度
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in this.winGridViewPager1.gridView1.Columns)
                {
                    column.Width = 100;
                }

                //可特殊设置特别的宽度
                //SetGridColumWidth("Note", 200);
            }
        }

        private void SetGridColumWidth(string columnName, int width)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = this.winGridViewPager1.gridView1.Columns.ColumnByFieldName(columnName);
            if (column != null)
            {
                column.Width = width;
            }
        }        
   
        /// <summary>
        /// 分页控件刷新操作
        /// </summary>
        private void winGridViewPager1_OnRefresh(object sender, EventArgs e)
        {
            BindData();
        }
        
        /// <summary>
        /// 分页控件删除操作
        /// </summary>
        private void winGridViewPager1_OnDeleteSelected(object sender, EventArgs e)
        {
            if (MessageDxUtil.ShowYesNoAndTips("您确定删除选定的记录么？") == DialogResult.No)
            {
                return;
            }

            int[] rowSelected = this.winGridViewPager1.GridView1.GetSelectedRows();
            foreach (int iRow in rowSelected)
            {
                string ID = this.winGridViewPager1.GridView1.GetRowCellDisplayText(iRow, "ID");
                CallerFactory<IStaffMonthAttendanceService>.Instance.Delete(ID);
            }	 
             
            BindData();
        }
        
        /// <summary>
        /// 分页控件编辑项操作
        /// </summary>
        private void winGridViewPager1_OnEditSelected(object sender, EventArgs e)
        {
            string ID = this.winGridViewPager1.gridView1.GetFocusedRowCellDisplayText("ID");
            List<string> IDList = new List<string>();
            for (int i = 0; i < this.winGridViewPager1.gridView1.RowCount; i++)
            {
                string strTemp = this.winGridViewPager1.GridView1.GetRowCellDisplayText(i, "ID");
                IDList.Add(strTemp);
            }

            if (!string.IsNullOrEmpty(ID))
            {
                FrmEditStaffMonthAttendance dlg = new FrmEditStaffMonthAttendance();
                dlg.ID = ID;
                dlg.IDList = IDList;
                dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
                dlg.InitFunction(LoginUserInfo, FunctionDict);//给子窗体赋值用户权限信息
                
                if (DialogResult.OK == dlg.ShowDialog())
                {
                    BindData();
                }
            }
        }        
        
        void dlg_OnDataSaved(object sender, EventArgs e)
        {
            BindData();
        }
        
        /// <summary>
        /// 分页控件新增操作
        /// </summary>        
        private void winGridViewPager1_OnAddNew(object sender, EventArgs e)
        {
            btnAddNew_Click(null, null);
        }
        
        /// <summary>
        /// 分页控件全部导出操作前的操作
        /// </summary> 
        private void winGridViewPager1_OnStartExport(object sender, EventArgs e)
        {
            string where = GetConditionSql();
            this.winGridViewPager1.AllToExport = CallerFactory<IStaffMonthAttendanceService>.Instance.FindToDataTable(where);
         }

        /// <summary>
        /// 分页控件翻页的操作
        /// </summary> 
        private void winGridViewPager1_OnPageChanged(object sender, EventArgs e)
        {
            BindData();
        }
        
        
        
      
        /// <summary>
        /// 查询数据操作
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
        	advanceCondition = null;//必须重置查询条件，否则可能会使用高级查询条件了
            BindData();
        }
        
        /// <summary>
        /// 新增数据操作
        /// </summary>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmEditStaffMonthAttendance dlg = new FrmEditStaffMonthAttendance();
            dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            dlg.InitFunction(LoginUserInfo, FunctionDict);//给子窗体赋值用户权限信息
            
            if (DialogResult.OK == dlg.ShowDialog())
            {
                BindData();
            }
        }
        
        /// <summary>
        /// 提供给控件回车执行查询的操作
        /// </summary>
        private void SearchControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }        

		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 		 
        private string moduleName = "StaffMonthAttendance";
        /// <summary>
        /// 导入Excel的操作
        /// </summary>          
        private void btnImport_Click(object sender, EventArgs e)
        {
            string templateFile = string.Format("{0}-模板.xls", moduleName);
            FrmImportExcelData dlg = new FrmImportExcelData();
            dlg.SetTemplate(templateFile, System.IO.Path.Combine(Application.StartupPath, templateFile));
            dlg.OnDataSave += new FrmImportExcelData.SaveDataHandler(ExcelData_OnDataSave);
            dlg.OnRefreshData += new EventHandler(ExcelData_OnRefreshData);
            dlg.ShowDialog();
        }

        void ExcelData_OnRefreshData(object sender, EventArgs e)
        {
            BindData();
        }

        /// <summary>
        /// 如果字段存在，则获取对应的值，否则返回默认空
        /// </summary>
        /// <param name="row">DataRow对象</param>
        /// <param name="columnName">字段列名</param>
        /// <returns></returns>
        private string GetRowData(DataRow row, string columnName)
        {
            string result = "";
            if (row.Table.Columns.Contains(columnName))
            {
                result = row[columnName].ToString();
            }
            return result;
        }
        
        bool ExcelData_OnDataSave(DataRow dr)
        {
            bool success = false;
            bool converted = false;
            DateTime dtDefault = Convert.ToDateTime("1900-01-01");
            DateTime dt;
            StaffMonthAttendanceInfo info = new StaffMonthAttendanceInfo();
            info.Id = GetRowData(dr, "Id");
              info.Year = GetRowData(dr, "Year").ToInt32();
              info.Month = GetRowData(dr, "Month").ToInt32();
              info.StaffId = GetRowData(dr, "StaffId");
              info.DepartmentId = GetRowData(dr, "DepartmentId");
              info.AttendanceDays = GetRowData(dr, "AttendanceDays").ToInt32();
              info.AnnualLeave = GetRowData(dr, "AnnualLeave").ToInt32();
              info.SickLeave = GetRowData(dr, "SickLeave").ToInt32();
              info.CasualLeave = GetRowData(dr, "CasualLeave").ToInt32();
              info.InjuryLeave = GetRowData(dr, "InjuryLeave").ToInt32();
              info.MarriageLeave = GetRowData(dr, "MarriageLeave").ToInt32();
              info.MaternityLeave = GetRowData(dr, "MaternityLeave").ToInt32();
              info.FuneralLeave = GetRowData(dr, "FuneralLeave").ToInt32();
              info.AbsentLeave = GetRowData(dr, "AbsentLeave").ToInt32();
              info.NormalOvertime = GetRowData(dr, "NormalOvertime").ToDecimal();
              info.WeekendOvertime = GetRowData(dr, "WeekendOvertime").ToDecimal();
              info.HolidayOvertime = GetRowData(dr, "HolidayOvertime").ToDecimal();
              info.NoonShift = GetRowData(dr, "NoonShift").ToInt32();
              info.NightShift = GetRowData(dr, "NightShift").ToInt32();
              info.OtherNoon = GetRowData(dr, "OtherNoon").ToInt32();
              info.OtherNight = GetRowData(dr, "OtherNight").ToInt32();
              info.Remark = GetRowData(dr, "Remark");
  
            success = CallerFactory<IStaffMonthAttendanceService>.Instance.Insert(info);
             return success;
        }

        /// <summary>
        /// 导出Excel的操作
        /// </summary>
        private void btnExport_Click(object sender, EventArgs e)
        {
            string file = FileDialogHelper.SaveExcel(string.Format("{0}.xls", moduleName));
            if (!string.IsNullOrEmpty(file))
            {
                string where = GetConditionSql();
                List<StaffMonthAttendanceInfo> list = CallerFactory<IStaffMonthAttendanceService>.Instance.Find(where);
                 DataTable dtNew = DataTableHelper.CreateTable("序号|int,Id,Year,Month,StaffId,DepartmentId,AttendanceDays,AnnualLeave,SickLeave,CasualLeave,InjuryLeave,MarriageLeave,MaternityLeave,FuneralLeave,AbsentLeave,NormalOvertime,WeekendOvertime,HolidayOvertime,NoonShift,NightShift,OtherNoon,OtherNight,Remark");
                DataRow dr;
                int j = 1;
                for (int i = 0; i < list.Count; i++)
                {
                    dr = dtNew.NewRow();
                    dr["序号"] = j++;
                    dr["Id"] = list[i].Id;
                     dr["Year"] = list[i].Year;
                     dr["Month"] = list[i].Month;
                     dr["StaffId"] = list[i].StaffId;
                     dr["DepartmentId"] = list[i].DepartmentId;
                     dr["AttendanceDays"] = list[i].AttendanceDays;
                     dr["AnnualLeave"] = list[i].AnnualLeave;
                     dr["SickLeave"] = list[i].SickLeave;
                     dr["CasualLeave"] = list[i].CasualLeave;
                     dr["InjuryLeave"] = list[i].InjuryLeave;
                     dr["MarriageLeave"] = list[i].MarriageLeave;
                     dr["MaternityLeave"] = list[i].MaternityLeave;
                     dr["FuneralLeave"] = list[i].FuneralLeave;
                     dr["AbsentLeave"] = list[i].AbsentLeave;
                     dr["NormalOvertime"] = list[i].NormalOvertime;
                     dr["WeekendOvertime"] = list[i].WeekendOvertime;
                     dr["HolidayOvertime"] = list[i].HolidayOvertime;
                     dr["NoonShift"] = list[i].NoonShift;
                     dr["NightShift"] = list[i].NightShift;
                     dr["OtherNoon"] = list[i].OtherNoon;
                     dr["OtherNight"] = list[i].OtherNight;
                     dr["Remark"] = list[i].Remark;
                     dtNew.Rows.Add(dr);
                }

                try
                {
                    string error = "";
                    AsposeExcelTools.DataTableToExcel2(dtNew, file, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageDxUtil.ShowError(string.Format("导出Excel出现错误：{0}", error));
                    }
                    else
                    {
                        if (MessageDxUtil.ShowYesNoAndTips("导出成功，是否打开文件？") == System.Windows.Forms.DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(file);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
         }
         
        private FrmAdvanceSearch dlg;
        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            if (dlg == null)
            {
                dlg = new FrmAdvanceSearch();
                dlg.FieldTypeTable = CallerFactory<IStaffMonthAttendanceService>.Instance.GetFieldTypeList();
                dlg.ColumnNameAlias = CallerFactory<IStaffMonthAttendanceService>.Instance.GetColumnNameAlias();                
                 dlg.DisplayColumns = "Id,Year,Month,StaffId,DepartmentId,AttendanceDays,AnnualLeave,SickLeave,CasualLeave,InjuryLeave,MarriageLeave,MaternityLeave,FuneralLeave,AbsentLeave,NormalOvertime,WeekendOvertime,HolidayOvertime,NoonShift,NightShift,OtherNoon,OtherNight,Remark";

                #region 下拉列表数据

                //dlg.AddColumnListItem("UserType", Portal.gc.GetDictData("人员类型"));//字典列表
                //dlg.AddColumnListItem("Sex", "男,女");//固定列表
                //dlg.AddColumnListItem("Credit", BLLFactory<StaffMonthAttendance>.Instance.GetFieldList("Credit"));//动态列表

                #endregion

                dlg.ConditionChanged += new FrmAdvanceSearch.ConditionChangedEventHandler(dlg_ConditionChanged);
            }
            dlg.ShowDialog();
        }

        void dlg_ConditionChanged(SearchCondition condition)
        {
            advanceCondition = condition;
            BindData();
        }
        #endregion //System

    }
}
