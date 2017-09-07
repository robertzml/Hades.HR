﻿using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;

using Hades.HR.Entity;
using Hades.HR.IDAL;
using Hades.HR.Util;
using Hades.Pager.Entity;
using Hades.Framework.ControlUtil;

namespace Hades.HR.BLL
{
    /// <summary>
    /// LaborSalaryRecord
    /// </summary>
	public class LaborSalaryRecord : BaseBLL<LaborSalaryRecordInfo>
    {
        #region Constructor
        public LaborSalaryRecord() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 计算计件工人工资
        /// </summary>
        /// <param name="attendanceId">考勤ID</param>
        /// <param name="workTeamId">班组ID</param>
        /// <returns></returns>
        public List<LaborSalaryRecordInfo> CalcLaborSalary(string attendanceId, string workTeamId)
        {
            List<LaborSalaryRecordInfo> data = new List<LaborSalaryRecordInfo>();

            // 获取考勤
            Attendance blAttendace = new Attendance();
            var attendaceInfo = blAttendace.FindByID(attendanceId);

            // 获取考勤记录
            DateTime d1 = new DateTime(attendaceInfo.Year, attendaceInfo.Month, 1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);

            string sql1 = string.Format("WorkTeamId = '{0}' AND AttendanceDate between '{1}' AND '{2}'", workTeamId, d1, d2);

            LaborAttendanceRecord blAttendaceRecord = new LaborAttendanceRecord();
            var records = blAttendaceRecord.Find(sql1);

            // 获取员工记录
            string sql2 = string.Format("WorkTeamId = '{0}' AND Year = {1} AND Month = {2}", workTeamId, attendaceInfo.Year, attendaceInfo.Month);

            WorkSectionLabor blLabor = new WorkSectionLabor();
            var labors = blLabor.Find(sql2);

            // 计算工资
            foreach (var labor in labors)
            {
                LaborSalaryRecordInfo info = new LaborSalaryRecordInfo();

                info.StaffId = labor.StaffId;

                info.AttendanceDays = records.Where(r => r.StaffId == info.StaffId && r.AbsentType == (int)AbsentType.None && r.IsWeekend == false && r.IsHoliday == false).Count();

                info.AnnualLeave = records.Where(r => r.StaffId == info.StaffId && r.AbsentType == (int)AbsentType.AnnualLeave).Count();
                info.SickLeave = records.Where(r => r.StaffId == info.StaffId && r.AbsentType == (int)AbsentType.SickLeave).Count();
                info.CasualLeave = records.Where(r => r.StaffId == info.StaffId && r.AbsentType == (int)AbsentType.CasualLeave).Count();
                info.AbsentLeave = records.Where(r => r.StaffId == info.StaffId && r.AbsentType == (int)AbsentType.AbsentLeave).Count();
                info.InjuryLeave = records.Where(r => r.StaffId == info.StaffId && r.AbsentType == (int)AbsentType.InjuryLeave).Count();

                info.MonthWorkload = records.Where(r => r.StaffId == info.StaffId).Sum(r => r.Workload);

                data.Add(info);
            }


            return data;
        }
        #endregion //Method
    }
}