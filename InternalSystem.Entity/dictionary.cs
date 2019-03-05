using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Entity
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("dictionary")]
    public partial class dictionary
    {
        #region 默认值

        public dictionary()
        {
            key = "";
            value = "";
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
        /// 键
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }

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