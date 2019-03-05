using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Entity
{/// <summary>
 /// 实体类。(属性说明自动提取数据库字段的描述信息)
 /// </summary>
    [Table("relevance")]
    public partial class relevance
    {
        #region 默认值

        public relevance()
        {
            dicvalue = "";
            effectid = 0;
        }

        #endregion 默认值

        #region Model

        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        /// <summary>
        /// 字典‘值’
        /// </summary>
        public string dicvalue { get; set; }

        /// <summary>
        /// 功能ID
        /// </summary>
        public int effectid { get; set; }

        /// <summary>
        /// 非SQL映射字段
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }

        [NotMapped]
        public string effectstr { get; set; }

        #endregion Model
    }
}