using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Entity
{
    /// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("users")]
    public partial class users
    {
        #region 默认值

        public users()
        {
            name = "";
            username = "";
            password = "";
            role = "";
            addtime = System.DateTime.Now;
            state = 0;
        }

        #endregion 默认值

        #region Model

        /// <summary>
        /// id
        /// </summary>
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 角色权限
        /// </summary>
        public string role { get; set; }

        /// <summary>
        /// 新建时间
        /// </summary>
        public DateTime? addtime { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        public int? state { get; set; }

        /// <summary>
        /// 非SQL映射字段
        /// </summary>
        [NotMapped]
        public string NotMapped { get; set; }

        #endregion Model
    }
}