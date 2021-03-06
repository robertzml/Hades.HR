﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

using Hades.Framework.Commons;
using Hades.Framework.ControlUtil;
using Hades.Framework.ControlUtil.Facade;
using Hades.HR.Entity;
using Hades.HR.BLL;
using Hades.HR.Facade;

namespace Hades.HR.ServiceCaller
{
    /// <summary>
    /// 基于WCF服务的Facade接口实现类
    /// </summary>
    public class StaffMonthAttendanceCaller : BaseWCFService<StaffMonthAttendanceInfo>, IStaffMonthAttendanceService
    {
        #region Constructor
        public StaffMonthAttendanceCaller() : base()
        {
            this.configurationPath = EndPointConfig.WcfConfig; //WCF配置文件
            this.endpointConfigurationName = EndPointConfig.StaffMonthAttendanceService;
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 子类构造一个IChannel对象转换为基类接口，方便给基类进行调用通用的API
        /// </summary>
        /// <returns></returns>
        protected override IBaseService<StaffMonthAttendanceInfo> CreateClient()
        {
            return CreateSubClient();
        }

        /// <summary>
        /// 创建一个强类型接口对象，供本地调用
        /// </summary>
        /// <returns></returns>
        private IStaffMonthAttendanceService CreateSubClient()
        {
            CustomClientChannel<IStaffMonthAttendanceService> factory = new CustomClientChannel<IStaffMonthAttendanceService>(endpointConfigurationName, configurationPath);
            return factory.CreateChannel();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 获取职员考勤记录
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<StaffMonthAttendanceInfo> GetRecords(int year, int month, string departmentId)
        {
            List<StaffMonthAttendanceInfo> result = new List<StaffMonthAttendanceInfo>();

            IStaffMonthAttendanceService service = CreateSubClient();
            ICommunicationObject comm = service as ICommunicationObject;
            comm.Using(client =>
            {
                result = service.GetRecords(year, month, departmentId);
            });

            return result;
        }

        /// <summary>
        /// 保存员工考勤记录
        /// </summary>
        /// <param name="data">考勤记录</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public bool SaveRecords(List<StaffMonthAttendanceInfo> data, int year, int month, string departmentId)
        {
            bool result = false;

            IStaffMonthAttendanceService service = CreateSubClient();
            ICommunicationObject comm = service as ICommunicationObject;
            comm.Using(client =>
            {
                result = service.SaveRecords(data, year, month, departmentId);
            });

            return result;
        }
        #endregion //Method
    }
}
