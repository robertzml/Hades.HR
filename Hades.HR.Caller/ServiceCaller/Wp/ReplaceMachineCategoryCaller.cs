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
    public class ReplaceMachineCategoryCaller : BaseWCFService<ReplaceMachineCategoryInfo>, IReplaceMachineCategoryService
    {
        public ReplaceMachineCategoryCaller()  : base()
        {	
            this.configurationPath = EndPointConfig.WcfConfig; //WCF配置文件
            this.endpointConfigurationName = EndPointConfig.ReplaceMachineCategoryService;
        }

        /// <summary>
        /// 子类构造一个IChannel对象转换为基类接口，方便给基类进行调用通用的API
        /// </summary>
        /// <returns></returns>
        protected override IBaseService<ReplaceMachineCategoryInfo> CreateClient()
        {
            return CreateSubClient();
        }

        /// <summary>
        /// 创建一个强类型接口对象，供本地调用
        /// </summary>
        /// <returns></returns>
        private IReplaceMachineCategoryService CreateSubClient()
        {
            CustomClientChannel<IReplaceMachineCategoryService> factory = new CustomClientChannel<IReplaceMachineCategoryService>(endpointConfigurationName, configurationPath);
            return factory.CreateChannel();
        }

        ///// <summary>
        ///// 根据名称查找对象(自定义接口使用范例)
        ///// </summary>
        //public List<ReplaceMachineCategoryInfo> FindByName(string name)
        //{
        //    List<ReplaceMachineCategoryInfo> result = new List<ReplaceMachineCategoryInfo>();

        //    IReplaceMachineCategoryService service = CreateSubClient();
        //    ICommunicationObject comm = service as ICommunicationObject;
        //    comm.Using(client =>
        //    {
        //        result = service.FindByName(name);
        //    });

        //    return result;
        //}


        ///// <summary>
        ///// 根据名称查找对象Asyn(自定义接口使用范例)
        ///// </summary>
        //public Task<List<ReplaceMachineCategoryInfo>> FindByNameAsyn(string name)
        //{
        //    IReplaceMachineCategoryService service = CreateSubClient();       
        //    return service.FindByNameAsyn(name);  
        //}
    }
}
