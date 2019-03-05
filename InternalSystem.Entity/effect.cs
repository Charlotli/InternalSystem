using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Entity
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("effect")]
    public partial class effect
    {
        #region 默认值

        public effect()
        {
            name = "";
            controllers = "";
            action = "";
            remark = "";
        }

        #endregion 默认值

        #region Model

        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        /// <summary>
        /// 功能名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 控制器
        /// </summary>
        public string controllers { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 非SQL映射字段
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }

        #endregion Model
    }
}