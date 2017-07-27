﻿using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using Hades.Pager.Entity;
using Hades.Framework.Commons;
using Hades.Framework.ControlUtil;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hades.HR.Entity;
using Hades.HR.IDAL;

namespace Hades.HR.DALSQL
{
    /// <summary>
    /// HR_StaffAttendanceView
    /// </summary>
	public class StaffAttendanceView : BaseDALSQL<StaffAttendanceViewInfo>, IStaffAttendanceView
    {
        #region 对象实例及构造函数

        public static StaffAttendanceView Instance
        {
            get
            {
                return new StaffAttendanceView();
            }
        }
        public StaffAttendanceView() : base("HR_StaffAttendanceView", "Id")
        {
        }

        #endregion

        /// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dr">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        protected override StaffAttendanceViewInfo DataReaderToEntity(IDataReader dataReader)
        {
            StaffAttendanceViewInfo info = new StaffAttendanceViewInfo();
            SmartDataReader reader = new SmartDataReader(dataReader);

            info.Id = reader.GetString("Id");
            info.AttendanceId = reader.GetString("AttendanceId");
            info.StaffId = reader.GetString("StaffId");
            info.AttendanceDays = reader.GetInt32("AttendanceDays");
            info.AnnualLeave = reader.GetInt32("AnnualLeave");
            info.SickLeave = reader.GetInt32("SickLeave");
            info.CasualLeave = reader.GetInt32("CasualLeave");
            info.InjuryLeave = reader.GetInt32("InjuryLeave");
            info.MarriageLeave = reader.GetInt32("MarriageLeave");
            info.LeaveDays = reader.GetInt32("LeaveDays");
            info.NormalOvertime = reader.GetInt32("NormalOvertime");
            info.NormalOvertimeSalary = reader.GetDecimal("NormalOvertimeSalary");
            info.WeekendOvertime = reader.GetInt32("WeekendOvertime");
            info.WeekendOvertimeSalary = reader.GetDecimal("WeekendOvertimeSalary");
            info.HolidayOvertime = reader.GetInt32("HolidayOvertime");
            info.HolidayOvertimeSalary = reader.GetDecimal("HolidayOvertimeSalary");
            info.OvertimeSalarySum = reader.GetDecimal("OvertimeSalarySum");
            info.NoonShift = reader.GetInt32("NoonShift");
            info.NightShift = reader.GetInt32("NightShift");
            info.OtherShift = reader.GetInt32("OtherShift");
            info.LunchAllowance = reader.GetDecimal("LunchAllowance");
            info.LeaderAllowance = reader.GetDecimal("LeaderAllowance");
            info.Deduction = reader.GetDecimal("Deduction");
            info.Nutrition = reader.GetDecimal("Nutrition");
            info.Remark = reader.GetString("Remark");
            info.Number = reader.GetString("Number");
            info.Name = reader.GetString("Name");
            info.DepartmentName = reader.GetString("DepartmentName");
            info.DepartmentId = reader.GetString("DepartmentId");

            return info;
        }

        /// <summary>
        /// 将实体对象的属性值转化为Hashtable对应的键值
        /// </summary>
        /// <param name="obj">有效的实体对象</param>
        /// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(StaffAttendanceViewInfo obj)
        {
            StaffAttendanceViewInfo info = obj as StaffAttendanceViewInfo;
            Hashtable hash = new Hashtable();

            hash.Add("Id", info.Id);
            hash.Add("AttendanceId", info.AttendanceId);
            hash.Add("StaffId", info.StaffId);
            hash.Add("AttendanceDays", info.AttendanceDays);
            hash.Add("AnnualLeave", info.AnnualLeave);
            hash.Add("SickLeave", info.SickLeave);
            hash.Add("CasualLeave", info.CasualLeave);
            hash.Add("InjuryLeave", info.InjuryLeave);
            hash.Add("MarriageLeave", info.MarriageLeave);
            hash.Add("LeaveDays", info.LeaveDays);
            hash.Add("NormalOvertime", info.NormalOvertime);
            hash.Add("NormalOvertimeSalary", info.NormalOvertimeSalary);
            hash.Add("WeekendOvertime", info.WeekendOvertime);
            hash.Add("WeekendOvertimeSalary", info.WeekendOvertimeSalary);
            hash.Add("HolidayOvertime", info.HolidayOvertime);
            hash.Add("HolidayOvertimeSalary", info.HolidayOvertimeSalary);
            hash.Add("OvertimeSalarySum", info.OvertimeSalarySum);
            hash.Add("NoonShift", info.NoonShift);
            hash.Add("NightShift", info.NightShift);
            hash.Add("OtherShift", info.OtherShift);
            hash.Add("LunchAllowance", info.LunchAllowance);
            hash.Add("LeaderAllowance", info.LeaderAllowance);
            hash.Add("Deduction", info.Deduction);
            hash.Add("Nutrition", info.Nutrition);
            hash.Add("Remark", info.Remark);
            hash.Add("Number", info.Number);
            hash.Add("Name", info.Name);
            hash.Add("DepartmentName", info.DepartmentName);
            hash.Add("DepartmentId", info.DepartmentId);

            return hash;
        }

        /// <summary>
        /// 获取字段中文别名（用于界面显示）的字典集合
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, string> GetColumnNameAlias()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            #region 添加别名解析
            //dict.Add("ID", "编号");
            dict.Add("Id", "");
            dict.Add("AttendanceId", "考勤ID");
            dict.Add("StaffId", "职员ID");
            dict.Add("AttendanceDays", "出勤天数");
            dict.Add("AnnualLeave", "年假天数");
            dict.Add("SickLeave", "病假天数");
            dict.Add("CasualLeave", "事假天数");
            dict.Add("InjuryLeave", "工伤天数");
            dict.Add("MarriageLeave", "婚产丧假天数");
            dict.Add("LeaveDays", "缺勤天数合计");
            dict.Add("NormalOvertime", "平时加班工时");
            dict.Add("NormalOvertimeSalary", "平时加班工资");
            dict.Add("WeekendOvertime", "周末加班工时");
            dict.Add("WeekendOvertimeSalary", "周末加班工资");
            dict.Add("HolidayOvertime", "法定假日加班工时");
            dict.Add("HolidayOvertimeSalary", "法定假日加班工资");
            dict.Add("OvertimeSalarySum", "加班工资合计");
            dict.Add("NoonShift", "中班天数");
            dict.Add("NightShift", "夜班天数");
            dict.Add("OtherShift", "其它中夜班天数");
            dict.Add("LunchAllowance", "午餐补贴");
            dict.Add("LeaderAllowance", "班组长补贴");
            dict.Add("Deduction", "扣款");
            dict.Add("Nutrition", "营养费");
            dict.Add("Remark", "备注");
            dict.Add("Number", "工号");
            dict.Add("Name", "姓名");
            dict.Add("DepartmentName", "部门名称");
            dict.Add("DepartmentId", "部门ID");
            #endregion

            return dict;
        }

    }
}