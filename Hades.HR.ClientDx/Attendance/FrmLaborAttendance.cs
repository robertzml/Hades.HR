using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Linq;
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
    /// LaborAttendanceRecord
    /// </summary>	
    public partial class FrmLaborAttendance : BaseDock
    {
        #region Constructor
        public FrmLaborAttendance()
        {
            InitializeComponent();

            InitDictItem();

   //         this.winGridViewPager1.OnPageChanged += new EventHandler(winGridViewPager1_OnPageChanged);
   //         this.winGridViewPager1.OnStartExport += new EventHandler(winGridViewPager1_OnStartExport);
   //         this.winGridViewPager1.OnEditSelected += new EventHandler(winGridViewPager1_OnEditSelected);
   //         this.winGridViewPager1.OnAddNew += new EventHandler(winGridViewPager1_OnAddNew);
   //         this.winGridViewPager1.OnDeleteSelected += new EventHandler(winGridViewPager1_OnDeleteSelected);
   //         this.winGridViewPager1.OnRefresh += new EventHandler(winGridViewPager1_OnRefresh);
   //         this.winGridViewPager1.AppendedMenu = this.contextMenuStrip1;
   //         this.winGridViewPager1.ShowLineNumber = true;
   //         this.winGridViewPager1.BestFitColumnWith = false;//�Ƿ�����Ϊ�Զ��������ȣ�falseΪ������
			//this.winGridViewPager1.gridView1.DataSourceChanged +=new EventHandler(gridView1_DataSourceChanged);
   //         this.winGridViewPager1.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView1_CustomColumnDisplayText);
   //         this.winGridViewPager1.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(gridView1_RowCellStyle);

        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// ��ʼ���ֵ��б�����
        /// </summary>
        private void InitDictItem()
        {
            //��ʼ������
        }

        /// <summary>
        /// ��ʼ���������б�
        /// </summary>
        private void InitWorkTeam()
        {
            var companys = CallerFactory<IDepartmentService>.Instance.Find("Type=2");
            var lines = CallerFactory<IProductionLineService>.Instance.Find("");
            var teams = CallerFactory<IWorkTeamService>.Instance.Find("");

            foreach(var com in companys)
            {
                TreeNode comNode = new TreeNode { Name = com.Id, Text = com.Name, Tag = 1 };
                var node = this.tvLine.Nodes.Add(comNode);

                var lines2 = lines.Where(r => r.CompanyId == com.Id);
                foreach(var line in lines2)
                {
                    TreeNode lineNode = new TreeNode { Name = line.Id, Text = line.Name, Tag = 2 };
                    var node2 = comNode.Nodes.Add(lineNode);

                    var teams2 = teams.Where(r => r.ProductionLineId == line.Id);
                    foreach(var team in teams2)
                    {
                        TreeNode teamNode = new TreeNode { Name = team.Id, Text = team.Name, Tag = 3 };
                        lineNode.Nodes.Add(teamNode);
                    }
                }

            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// ��д��ʼ�������ʵ�֣���������ˢ��
        /// </summary>
        public override void FormOnLoad()
        {
            InitWorkTeam();
        }
        #endregion //Method

        #region Event
      
        private void dpAttendance_EditValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// �༭���ڼ�¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            var node = this.tvLine.SelectedNode;
            if (node == null || Convert.ToInt32(node.Tag) != 3)
            {
                MessageDxUtil.ShowWarning("��ѡ�����");
                return;
            }
            if (this.dpAttendance.EditValue == null)
            {
                MessageDxUtil.ShowWarning("��ѡ��������");
                return;
            }

            var teamId = node.Name;
            var date = this.dpAttendance.DateTime.Date;

            FrmEditLaborAttendanceRecord dlg = new FrmEditLaborAttendanceRecord(date, teamId);
            dlg.InitFunction(LoginUserInfo, FunctionDict);//���Ӵ��帳ֵ�û�Ȩ����Ϣ
            if (DialogResult.OK == dlg.ShowDialog())
            {
                //LoadRecordData();
            }
        }
        #endregion //Event

        void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.FieldName == "OrderStatus")
            //{
            //    string status = this.winGridViewPager1.gridView1.GetRowCellValue(e.RowHandle, "OrderStatus").ToString();
            //    Color color = Color.White;
            //    if (status == "�����")
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
            //    e.DisplayText = string.Format("{0}��", e.Value);
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
        /// �����ݺ󣬷�����еĿ���
        /// </summary>
        private void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.wgvRecord.gridView1.Columns.Count > 0 && this.wgvRecord.gridView1.RowCount > 0)
            {
                //ͳһ����100����
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in this.wgvRecord.gridView1.Columns)
                {
                    column.Width = 100;
                }

                //�����������ر�Ŀ���
                //SetGridColumWidth("Note", 200);
            }
        }

        private void SetGridColumWidth(string columnName, int width)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = this.wgvRecord.gridView1.Columns.ColumnByFieldName(columnName);
            if (column != null)
            {
                column.Width = width;
            }
        }

    
        
    
        
        /// <summary>
        /// ��ҳ�ؼ�ˢ�²���
        /// </summary>
        private void winGridViewPager1_OnRefresh(object sender, EventArgs e)
        {
            BindData();
        }
        
        /// <summary>
        /// ��ҳ�ؼ�ɾ������
        /// </summary>
        private void winGridViewPager1_OnDeleteSelected(object sender, EventArgs e)
        {
            if (MessageDxUtil.ShowYesNoAndTips("��ȷ��ɾ��ѡ���ļ�¼ô��") == DialogResult.No)
            {
                return;
            }

            int[] rowSelected = this.wgvRecord.GridView1.GetSelectedRows();
            foreach (int iRow in rowSelected)
            {
                string ID = this.wgvRecord.GridView1.GetRowCellDisplayText(iRow, "ID");
                CallerFactory<ILaborAttendanceRecordService>.Instance.Delete(ID);
            }	 
             
            BindData();
        }
        
        /// <summary>
        /// ��ҳ�ؼ��༭�����
        /// </summary>
        private void winGridViewPager1_OnEditSelected(object sender, EventArgs e)
        {
            string ID = this.wgvRecord.gridView1.GetFocusedRowCellDisplayText("ID");
            List<string> IDList = new List<string>();
            for (int i = 0; i < this.wgvRecord.gridView1.RowCount; i++)
            {
                string strTemp = this.wgvRecord.GridView1.GetRowCellDisplayText(i, "ID");
                IDList.Add(strTemp);
            }

            //if (!string.IsNullOrEmpty(ID))
            //{
            //    FrmEditLaborAttendanceRecord dlg = new FrmEditLaborAttendanceRecord();
            //    dlg.ID = ID;
            //    dlg.IDList = IDList;
            //    dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            //    dlg.InitFunction(LoginUserInfo, FunctionDict);//���Ӵ��帳ֵ�û�Ȩ����Ϣ
                
            //    if (DialogResult.OK == dlg.ShowDialog())
            //    {
            //        BindData();
            //    }
            //}
        }        
        
        void dlg_OnDataSaved(object sender, EventArgs e)
        {
            BindData();
        }
        
        /// <summary>
        /// ��ҳ�ؼ���������
        /// </summary>        
        private void winGridViewPager1_OnAddNew(object sender, EventArgs e)
        {
            btnAddNew_Click(null, null);
        }
        
        /// <summary>
        /// ��ҳ�ؼ�ȫ����������ǰ�Ĳ���
        /// </summary> 
        private void winGridViewPager1_OnStartExport(object sender, EventArgs e)
        {
            string where = GetConditionSql();
            this.wgvRecord.AllToExport = CallerFactory<ILaborAttendanceRecordService>.Instance.FindToDataTable(where);
         }

        /// <summary>
        /// ��ҳ�ؼ���ҳ�Ĳ���
        /// </summary> 
        private void winGridViewPager1_OnPageChanged(object sender, EventArgs e)
        {
            BindData();
        }
        
        /// <summary>
        /// �߼���ѯ����������
        /// </summary>
        private SearchCondition advanceCondition;
        
        /// <summary>
        /// ���ݲ�ѯ���������ѯ���
        /// </summary> 
        private string GetConditionSql()
        {
            //������ڸ߼���ѯ������Ϣ����ʹ�ø߼���ѯ����������ʹ������������ѯ
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
        /// ���б�����
        /// </summary>
        private void BindData()
        {
        	//entity
            this.wgvRecord.DisplayColumns = "StaffId,AttendanceDate,Workload,AbsentType";
            this.wgvRecord.ColumnNameAlias = CallerFactory<ILaborAttendanceRecordService>.Instance.GetColumnNameAlias();//�ֶ�����ʾ����ת��

            #region ���ӱ�������

            //this.winGridViewPager1.AddColumnAlias("StaffId", "StaffId");
            //this.winGridViewPager1.AddColumnAlias("AttendanceDate", "AttendanceDate");
            //this.winGridViewPager1.AddColumnAlias("Workload", "Workload");
            //this.winGridViewPager1.AddColumnAlias("AbsentType", "AbsentType");

            #endregion

            string where = GetConditionSql();
            PagerInfo pagerInfo = this.wgvRecord.PagerInfo;
               List<LaborAttendanceRecordInfo> list = CallerFactory<ILaborAttendanceRecordService>.Instance.FindWithPager(where, ref pagerInfo);
            this.wgvRecord.PagerInfo.RecordCount = pagerInfo.RecordCount;
            this.wgvRecord.DataSource = new Hades.Pager.WinControl.SortableBindingList<LaborAttendanceRecordInfo>(list);
               this.wgvRecord.PrintTitle = "LaborAttendanceRecord����";
         }
        
        /// <summary>
        /// ��ѯ���ݲ���
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
        	advanceCondition = null;//�������ò�ѯ������������ܻ�ʹ�ø߼���ѯ������
            BindData();
        }
        
        /// <summary>
        /// �������ݲ���
        /// </summary>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //FrmEditLaborAttendanceRecord dlg = new FrmEditLaborAttendanceRecord();
            //dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            //dlg.InitFunction(LoginUserInfo, FunctionDict);//���Ӵ��帳ֵ�û�Ȩ����Ϣ
            
            //if (DialogResult.OK == dlg.ShowDialog())
            //{
            //    BindData();
            //}
        }
        
        /// <summary>
        /// �ṩ���ؼ��س�ִ�в�ѯ�Ĳ���
        /// </summary>
        private void SearchControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }        

		 		 		 		 		 
        private string moduleName = "LaborAttendanceRecord";
        /// <summary>
        /// ����Excel�Ĳ���
        /// </summary>          
        private void btnImport_Click(object sender, EventArgs e)
        {
            string templateFile = string.Format("{0}-ģ��.xls", moduleName);
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
        /// ����ֶδ��ڣ����ȡ��Ӧ��ֵ�����򷵻�Ĭ�Ͽ�
        /// </summary>
        /// <param name="row">DataRow����</param>
        /// <param name="columnName">�ֶ�����</param>
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
            LaborAttendanceRecordInfo info = new LaborAttendanceRecordInfo();
            info.Id = GetRowData(dr, "Id");
              info.StaffId = GetRowData(dr, "StaffId");
  
            string AttendanceDate = GetRowData(dr, "AttendanceDate");
            if (!string.IsNullOrEmpty(AttendanceDate))
            {
				converted = DateTime.TryParse(AttendanceDate, out dt);
                if (converted && dt > dtDefault)
                {
                    info.AttendanceDate = dt;
                }
			}
            else
            {
                info.AttendanceDate = DateTime.Now;
            }

              info.Workload = GetRowData(dr, "Workload").ToDecimal();
              info.AbsentType = GetRowData(dr, "AbsentType").ToInt32();
  
            success = CallerFactory<ILaborAttendanceRecordService>.Instance.Insert(info);
             return success;
        }

        /// <summary>
        /// ����Excel�Ĳ���
        /// </summary>
        private void btnExport_Click(object sender, EventArgs e)
        {
            string file = FileDialogHelper.SaveExcel(string.Format("{0}.xls", moduleName));
            if (!string.IsNullOrEmpty(file))
            {
                string where = GetConditionSql();
                List<LaborAttendanceRecordInfo> list = CallerFactory<ILaborAttendanceRecordService>.Instance.Find(where);
                 DataTable dtNew = DataTableHelper.CreateTable("���|int,Id,StaffId,AttendanceDate,Workload,AbsentType");
                DataRow dr;
                int j = 1;
                for (int i = 0; i < list.Count; i++)
                {
                    dr = dtNew.NewRow();
                    dr["���"] = j++;
                    dr["Id"] = list[i].Id;
                     dr["StaffId"] = list[i].StaffId;
                     dr["AttendanceDate"] = list[i].AttendanceDate;
                     dr["Workload"] = list[i].Workload;
                     dr["AbsentType"] = list[i].AbsentType;
                     dtNew.Rows.Add(dr);
                }

                try
                {
                    string error = "";
                    AsposeExcelTools.DataTableToExcel2(dtNew, file, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageDxUtil.ShowError(string.Format("����Excel���ִ���{0}", error));
                    }
                    else
                    {
                        if (MessageDxUtil.ShowYesNoAndTips("�����ɹ����Ƿ���ļ���") == System.Windows.Forms.DialogResult.Yes)
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
                dlg.FieldTypeTable = CallerFactory<ILaborAttendanceRecordService>.Instance.GetFieldTypeList();
                dlg.ColumnNameAlias = CallerFactory<ILaborAttendanceRecordService>.Instance.GetColumnNameAlias();                
                 dlg.DisplayColumns = "Id,StaffId,AttendanceDate,Workload,AbsentType";

                #region �����б�����

                //dlg.AddColumnListItem("UserType", Portal.gc.GetDictData("��Ա����"));//�ֵ��б�
                //dlg.AddColumnListItem("Sex", "��,Ů");//�̶��б�
                //dlg.AddColumnListItem("Credit", BLLFactory<LaborAttendanceRecord>.Instance.GetFieldList("Credit"));//��̬�б�

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

    }
}