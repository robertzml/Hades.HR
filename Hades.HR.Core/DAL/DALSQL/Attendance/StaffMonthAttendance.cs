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
    /// StaffMonthAttendance
    /// </summary>
	public class StaffMonthAttendance : BaseDALSQL<StaffMonthAttendanceInfo>, IStaffMonthAttendance
    {
        #region 对象实例及构造函数

        public static StaffMonthAttendance Instance
        {
            get
            {
                return new StaffMonthAttendance();
            }
        }
        public StaffMonthAttendance() : base("HR_StaffMonthAttendance", "Id")
        {
        }

        #endregion

        /// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dr">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        protected override StaffMonthAttendanceInfo DataReaderToEntity(IDataReader dataReader)
        {
            StaffMonthAttendanceInfo info = new StaffMonthAttendanceInfo();
            SmartDataReader reader = new SmartDataReader(dataReader);

            info.Id = reader.GetString("Id");
            info.Year = reader.GetInt32("Year");
            info.Month = reader.GetInt32("Month");
            info.StaffId = reader.GetString("StaffId");
            info.DepartmentId = reader.GetString("DepartmentId");
            info.AttendanceDays = reader.GetInt32("AttendanceDays");
            info.AnnualLeave = reader.GetInt32("AnnualLeave");
            info.SickLeave = reader.GetInt32("SickLeave");
            info.CasualLeave = reader.GetInt32("CasualLeave");
            info.InjuryLeave = reader.GetInt32("InjuryLeave");
            info.MarriageLeave = reader.GetInt32("MarriageLeave");
            info.MaternityLeave = reader.GetInt32("MaternityLeave");
            info.FuneralLeave = reader.GetInt32("FuneralLeave");
            info.AbsentLeave = reader.GetInt32("AbsentLeave");
            info.NormalOvertime = reader.GetDecimal("NormalOvertime");
            info.WeekendOvertime = reader.GetDecimal("WeekendOvertime");
            info.HolidayOvertime = reader.GetDecimal("HolidayOvertime");
            info.NoonShift = reader.GetInt32("NoonShift");
            info.NightShift = reader.GetInt32("NightShift");
            info.OtherNoon = reader.GetInt32("OtherNoon");
            info.OtherNight = reader.GetInt32("OtherNight");
            info.Remark = reader.GetString("Remark");

            return info;
        }

        /// <summary>
        /// 将实体对象的属性值转化为Hashtable对应的键值
        /// </summary>
        /// <param name="obj">有效的实体对象</param>
        /// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(StaffMonthAttendanceInfo obj)
        {
            StaffMonthAttendanceInfo info = obj as StaffMonthAttendanceInfo;
            Hashtable hash = new Hashtable();

            hash.Add("Id", info.Id);
            hash.Add("Year", info.Year);
            hash.Add("Month", info.Month);
            hash.Add("StaffId", info.StaffId);
            hash.Add("DepartmentId", info.DepartmentId);
            hash.Add("AttendanceDays", info.AttendanceDays);
            hash.Add("AnnualLeave", info.AnnualLeave);
            hash.Add("SickLeave", info.SickLeave);
            hash.Add("CasualLeave", info.CasualLeave);
            hash.Add("InjuryLeave", info.InjuryLeave);
            hash.Add("MarriageLeave", info.MarriageLeave);
            hash.Add("MaternityLeave", info.MaternityLeave);
            hash.Add("FuneralLeave", info.FuneralLeave);
            hash.Add("AbsentLeave", info.AbsentLeave);
            hash.Add("NormalOvertime", info.NormalOvertime);
            hash.Add("WeekendOvertime", info.WeekendOvertime);
            hash.Add("HolidayOvertime", info.HolidayOvertime);
            hash.Add("NoonShift", info.NoonShift);
            hash.Add("NightShift", info.NightShift);
            hash.Add("OtherNoon", info.OtherNoon);
            hash.Add("OtherNight", info.OtherNight);
            hash.Add("Remark", info.Remark);

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
            dict.Add("Year", "年");
            dict.Add("Month", "月");
            dict.Add("StaffId", "员工姓名");
            dict.Add("DepartmentId", "部门名称");
            dict.Add("AttendanceDays", "出勤天数");
            dict.Add("AnnualLeave", "年假天数");
            dict.Add("SickLeave", "病假天数");
            dict.Add("CasualLeave", "事假天数");
            dict.Add("InjuryLeave", "工伤天数");
            dict.Add("MarriageLeave", "婚假天数");
            dict.Add("MaternityLeave", "产假天数");
            dict.Add("FuneralLeave", "丧假天数");
            dict.Add("AbsentLeave", "缺勤天数");
            dict.Add("NormalOvertime", "平时加班工时");
            dict.Add("WeekendOvertime", "周末加班工时");
            dict.Add("HolidayOvertime", "节假日加班工时");
            dict.Add("NoonShift", "中班天数");
            dict.Add("NightShift", "夜班天数");
            dict.Add("OtherNoon", "其它中班天数");
            dict.Add("OtherNight", "其它夜班天数");
            dict.Add("Remark", "备注");
            #endregion

            return dict;
        }
    }
}