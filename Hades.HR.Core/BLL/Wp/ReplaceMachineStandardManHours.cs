﻿using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using Hades.HR.Entity;
using Hades.HR.IDAL;
using Hades.Pager.Entity;
using Hades.Framework.ControlUtil;

namespace Hades.HR.BLL
{
    /// <summary>
    /// ReplaceMachineStandardManHours
    /// </summary>
	public class ReplaceMachineStandardManHours : BaseBLL<ReplaceMachineStandardManHoursInfo>
    {
        public ReplaceMachineStandardManHours() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
    }
}
