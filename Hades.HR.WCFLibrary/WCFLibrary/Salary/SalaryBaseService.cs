﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using Hades.Framework.Commons;
using Hades.Framework.ControlUtil;
using Hades.Framework.ControlUtil.Facade;
using Hades.HR.Entity;
using Hades.HR.BLL;
using Hades.HR.Facade;

namespace Hades.HR.WCFLibrary
{
	/// <summary>
	/// 基于WCFLibrary的SalaryBase对象调用类
	/// </summary>
    public class SalaryBaseService : BaseLocalService<SalaryBaseInfo>, ISalaryBaseService
    {
        private SalaryBase bll = null;

        public SalaryBaseService() : base(BLLFactory<SalaryBase>.Instance)
        {
            bll = baseBLL as SalaryBase;
        }

        ///// <summary>
        ///// 根据名称查找对象(自定义接口使用范例)
        ///// </summary>
        //public List<SalaryBaseInfo> FindByName(string name)
        //{
        //    return bll.FindByName(name);
        //}

        ///// <summary>
        ///// 根据名称查找对象(自定义接口使用范例)
        ///// </summary>
        //public async Task<List<SalaryBaseInfo>> FindByNameAsyn(string name)
        //{
        //   return await Task.Factory.StartNew(() =>
        //   {
        //       return bll.FindByName(name);
	//   }
        //}

    }
}
