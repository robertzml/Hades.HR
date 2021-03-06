﻿using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Hades.Framework.ControlUtil;

namespace Hades.HR.Entity
{
    /// <summary>
    /// 班组类
    /// </summary>
    [DataContract]
    public class WorkTeamInfo : BaseEntity
    {
        /// <summary>
        /// 默认构造函数（需要初始化属性的在此处理）
        /// </summary>
        public WorkTeamInfo()
        {
            this.Id = System.Guid.NewGuid().ToString();
            this.Deleted = 0;
            this.Enabled = 0;
        }

        #region Property Members

        [DataMember]
        public virtual string Id { get; set; }

        [DataMember]
        public virtual string Name { get; set; }

        [DataMember]
        public virtual string Number { get; set; }

        [DataMember]
        public virtual string CompanyId { get; set; }

        [DataMember]
        public virtual string WorkSectionId { get; set; }

        [DataMember]
        public virtual int Quota { get; set; }

        [DataMember]
        public virtual string Principal { get; set; }

        [DataMember]
        public virtual string SortCode { get; set; }

        [DataMember]
        public virtual string Remark { get; set; }

        [DataMember]
        public virtual string Creator { get; set; }

        [DataMember]
        public virtual string CreatorId { get; set; }

        [DataMember]
        public virtual DateTime CreateTime { get; set; }

        [DataMember]
        public virtual string Editor { get; set; }

        [DataMember]
        public virtual string EditorId { get; set; }

        [DataMember]
        public virtual DateTime EditTime { get; set; }

        [DataMember]
        public virtual int Deleted { get; set; }

        [DataMember]
        public virtual int Enabled { get; set; }
        #endregion
    }
}