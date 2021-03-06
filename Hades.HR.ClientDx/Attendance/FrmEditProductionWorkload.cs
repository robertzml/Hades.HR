using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

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
    /// 编辑产量工时
    /// </summary>
    public partial class FrmEditProductionWorkload : BaseEditForm
    {
        #region Field
        /// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
        private WorkTeamDailyWorkloadInfo tempInfo = new WorkTeamDailyWorkloadInfo();

        /// <summary>
        /// 完工单数据
        /// </summary>
        //private List<CompleteForm> completeForms = new List<CompleteForm>();

        /// <summary>
        /// 完工单详细信息
        /// </summary>
        //private List<CompleteDetails> completeDetails = new List<CompleteDetails>();

        /// <summary>
        /// 缓存完工数据
        /// </summary>
        private List<CompletionListInfo> completionList = new List<CompletionListInfo>();
        
        /// <summary>
        /// 暂存产量工时数据
        /// </summary>
        private List<LaborProductionWorkloadInfo> laborProductions = new List<LaborProductionWorkloadInfo>();

        /// <summary>
        /// 缓存员工日工作量
        /// </summary>
        private List<LaborDailyWorkloadInfo> laborWorkloads = new List<LaborDailyWorkloadInfo>();

        /// <summary>
        /// 缓存职员数据
        /// </summary>
        private List<StaffInfo> staffs;
        #endregion //Field

        #region Constructor
        public FrmEditProductionWorkload()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
            //初始化代码
        }

        /// <summary>
        /// 载入完工单数据
        /// </summary>
        private void LoadCompletions()
        {
            string sql = string.Format("WorkteamId = '{0}' AND EndTime = '{1}'", this.tempInfo.WorkTeamId, this.tempInfo.AttendanceDate);
            this.completionList = CallerFactory<ICompletionListService>.Instance.Find(sql);
        }

        /// <summary>
        /// 显示完工单列表
        /// </summary>
        private void DisplayCompletionList()
        {
            this.lvComplete.DataSource = completionList;
            this.lvComplete.DisplayMember = "CompletionListID";
            this.lvComplete.ValueMember = "Id";
        }

        /// <summary>
        /// 生成完工单列表
        /// </summary>
        /// <param name="dt"></param>
        private void GenerateForm(DateTime dt)
        {
            //Random random = new Random(dt.Day);

            //this.lvComplete.Items.Clear();

            //int days = random.Next(2, 6);
            //for (int i = 0; i < days; i++)
            //{
            //    string id = Guid.NewGuid().ToString();
            //    string number = string.Format("{0:D4}{1:D2}{2:D3}-{3:D3}", dt.Year, dt.Month, dt.Day, i);

            //    CompleteForm form = new CompleteForm();
            //    form.Id = id;
            //    form.Number = number;

            //    completeForms.Add(form);

            //    GenerateCompleteDetails(form.Id, i);
            //}

            //this.lvComplete.DataSource = completeForms;
            //this.lvComplete.DisplayMember = "Number";
            //this.lvComplete.ValueMember = "Id";
        }

        /// <summary>
        /// 生成完工数据
        /// </summary>
        private void GenerateCompleteDetails(string completeId, int index)
        {
            //Random random = new Random(DateTime.Now.Millisecond + index);

            //CompleteDetails form1 = new CompleteDetails();
            //form1.CompleteId = completeId;
            //form1.Name = "桶身圈圆";
            //form1.Production = 1700 * (decimal)(random.Next(50, 100) / 100m);
            //form1.Quota = 196;
            //form1.Workload = Math.Round(form1.Production / form1.Quota, 2);

            //CompleteDetails form2 = new CompleteDetails();
            //form2.CompleteId = completeId;
            //form2.Name = "桶身点焊";
            //form2.Production = 1700 * (decimal)(random.Next(50, 100) / 100m);
            //form2.Quota = 98;
            //form2.Workload = Math.Round(form2.Production / form2.Quota, 2);

            //CompleteDetails form3 = new CompleteDetails();
            //form3.CompleteId = completeId;
            //form3.Name = "桶身缝焊";
            //form3.Production = 1700 * (decimal)(random.Next(50, 100) / 100m);
            //form3.Quota = 196;
            //form3.Workload = Math.Round(form3.Production / form3.Quota, 2);

            //completeDetails.Add(form1);
            //completeDetails.Add(form2);
            //completeDetails.Add(form3);
        }

        /// <summary>
        /// 载入职员相关产量工时
        /// </summary>
        private void LoadLaborProduction()
        {
            foreach (var item in this.completionList)
            {
                var data = CallerFactory<ILaborProductionWorkloadService>.Instance.Find(string.Format("CompleteId = '{0}'", item.ID));

                this.laborProductions.AddRange(data);
            }
        }

        /// <summary>
        /// 显示完工记录
        /// </summary>
        /// <param name="completeId"></param>
        private void DisplayDetails(string completeId)
        {
            this.wgvComplete.DisplayColumns = "CompletionListID,AcceptanceAmount";

            this.wgvComplete.AddColumnAlias("CompletionListID", "完工单编号");
            this.wgvComplete.AddColumnAlias("AcceptanceAmount", "产量工时");

            var data = this.completionList.Where(r => r.ID == completeId);
            this.wgvComplete.DataSource = data;
        }

        /// <summary>
        /// 显示职员信息
        /// </summary>
        /// <param name="completeId">完工单ID</param>
        private void DisplayLaborProduction(string completeId)
        {
            var find = this.laborProductions.Where(r => r.CompleteId == completeId).ToList();
            if (find.Count() == 0)
            {
                var staffs = CallerFactory<ILaborDailyWorkloadService>.Instance.Find(string.Format("WorkTeamWorkloadId='{0}'", this.ID));

                List<LaborProductionWorkloadInfo> data = new List<LaborProductionWorkloadInfo>();
                foreach (var item in staffs)
                {
                    LaborProductionWorkloadInfo info = new LaborProductionWorkloadInfo();
                    info.CompleteId = completeId;
                    info.WorkTeamId = this.tempInfo.WorkTeamId;
                    info.StaffId = item.StaffId;
                    info.AttendanceDate = this.tempInfo.AttendanceDate;

                    data.Add(info);
                }

                this.bsLaborWorkload.DataSource = data;
            }
            else
            {
                this.bsLaborWorkload.DataSource = find;

                this.dgvStaff.SelectionChanged -= new DevExpress.Data.SelectionChangedEventHandler(this.dgvStaff_SelectionChanged);
                for (int i = 0;i < find.Count; i++)
                {
                    if (find[i].ProductionHours !=0)
                    {
                        this.dgvStaff.SelectRow(i);
                    }
                }

                this.dgvStaff.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.dgvStaff_SelectionChanged);
            }
        }

        /// <summary>
        /// 计算工时
        /// </summary>
        private void CalculateHours()
        {
            if (this.lvComplete.SelectedIndex == -1 || this.lvComplete.SelectedItem == null)
                return;

            var form = this.lvComplete.SelectedItem as CompletionListInfo;
            decimal totalHours = this.completionList.Where(r => r.ID == form.ID).Sum(r => r.AcceptanceAmount);

            var selected = this.dgvStaff.GetSelectedRows();
            if (selected.Length == 0)
                return;

            var one = Math.Round(totalHours / selected.Length, 3);

            for (int i = 0; i < this.dgvStaff.RowCount; i++)
            {
                int dsIndex = this.dgvStaff.GetDataSourceRowIndex(i);
                var workload = this.bsLaborWorkload[dsIndex] as LaborProductionWorkloadInfo;
                if (dgvStaff.IsRowSelected(i))
                {
                    workload.ProductionHours = one;
                }
                else
                {
                    workload.ProductionHours = 0;
                }
            }

            this.dgvStaff.RefreshData();
        }

        /// <summary>
        /// 暂存完工单
        /// </summary>
        /// <param name="completeId">完工单ID</param>
        private void StoreCompleteForm(string completeId)
        {
            this.laborProductions.RemoveAll(r => r.CompleteId == completeId);

            var data = this.bsLaborWorkload.DataSource as List<LaborProductionWorkloadInfo>;

            foreach (var item in data)
            {
                item.AssignType = 1;
                item.Remark = item.Remark ?? "";
            }
            this.laborProductions.AddRange(data);
        }
        #endregion //Function

        #region Method
        public override void ClearScreen()
        {
            this.tempInfo = new WorkTeamDailyWorkloadInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//默认是可以通过

            return result;
        }

        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public override void DisplayData()
        {
            InitDictItem();//数据字典加载（公用）

            this.Text = "编辑班组产量工时";

            if (!string.IsNullOrEmpty(ID))
            {
                WorkTeamDailyWorkloadInfo info = CallerFactory<IWorkTeamDailyWorkloadService>.Instance.FindByID(ID);
                if (info != null)
                {
                    tempInfo = info;//重新给临时对象赋值，使之指向存在的记录对象

                    var workTeam = CallerFactory<IWorkTeamService>.Instance.FindByID(info.WorkTeamId);
                    this.txtWorkTeamName.Text = workTeam.Name;
                    this.txtAttendanceDate.Text = info.AttendanceDate.ToString("yyyy-MM-dd");

                    this.staffs = CallerFactory<IStaffService>.Instance.Find("StaffType = 2");
                    this.laborWorkloads = CallerFactory<ILaborDailyWorkloadService>.Instance.Find(string.Format("WorkTeamWorkloadId='{0}'", ID));

                    LoadCompletions();

                    if (this.completionList.Count > 0)
                    {
                        DisplayCompletionList();

                        LoadLaborProduction();

                        txtProductionHours.Value = this.completionList.Sum(r => r.AcceptanceAmount);
                    }
                    else
                    {
                        this.txtProductionHours.Value = 0;                        
                    }
                }

                //this.btnOK.Enabled = HasFunction("WorkTeamDailyWorkload/Edit");             
            }
            else
            {
                //this.btnOK.Enabled = Portal.gc.HasFunction("WorkTeamDailyWorkload/Add");  
            }
        }

        /// <summary>
        /// 编辑状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveUpdated()
        {
            WorkTeamDailyWorkloadInfo info = CallerFactory<IWorkTeamDailyWorkloadService>.Instance.FindByID(ID);
            if (info != null)
            {
                try
                {
                    var totalHours = this.completionList.Sum(r => r.AcceptanceAmount);

                    if (laborProductions.Sum(r => r.ProductionHours) != totalHours)
                    {
                        MessageDxUtil.ShowWarning("分配产量工时与总数不等");
                        return false;
                    }

                    bool succeed = CallerFactory<IWorkTeamDailyWorkloadService>.Instance.SaveProduction(this.ID, totalHours, this.laborProductions);
                    
                    return succeed;
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
            return false;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 完工单选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvComplete.SelectedIndex != -1 && this.lvComplete.SelectedItem != null)
            {
                var form = this.lvComplete.SelectedItem as CompletionListInfo;
                DisplayDetails(form.ID);
                DisplayLaborProduction(form.ID);
            }
        }

        /// <summary>
        /// 格式化显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStaff_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            string columnName = e.Column.FieldName;
            if (columnName == "StaffId")
            {
                if (e.Value != null)
                {
                    var s = this.staffs.SingleOrDefault(r => r.Id == e.Value.ToString());
                    if (s == null)
                        e.DisplayText = "";
                    else
                        e.DisplayText = s.Name;
                }
            }
            else if (columnName == "CompleteId")
            {
                if (e.Value != null)
                {
                    var s = this.completionList.SingleOrDefault(r => r.ID == e.Value.ToString());
                    if (s == null)
                        e.DisplayText = "";
                    else
                        e.DisplayText = s.CompletionListID;
                }
            }
        }

        /// <summary>
        /// 自定义数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStaff_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsLaborWorkload.Count)
                return;

            var record = this.bsLaborWorkload[rowIndex] as LaborProductionWorkloadInfo;

            if (e.Column.FieldName == "StaffNumber" && e.IsGetData)
            {
                var s = this.staffs.SingleOrDefault(r => r.Id == record.StaffId);
                if (s == null)
                    e.Value = "";
                else
                    e.Value = s.Number;
            }
        }

        /// <summary>
        /// 职员选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStaff_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            CalculateHours();
        }

        /// <summary>
        /// 暂存完工单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveCurrent_Click(object sender, EventArgs e)
        {
            if (this.lvComplete.SelectedIndex != -1 && this.lvComplete.SelectedItem != null)
            {
                var form = this.lvComplete.SelectedItem as CompletionListInfo;
                StoreCompleteForm(form.ID);
            }
        }
        #endregion //Event
    }
}
