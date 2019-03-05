using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Entity
{ /// <summary>
  /// 实体类。(属性说明自动提取数据库字段的描述信息)
  /// </summary>
    [Table("view_users_relevance")]
    public partial class view_users_relevance
    {
        #region 默认值
        public view_users_relevance()
        {
            id = 0;
            name = "";
            username = "";
            password = "";
            role = "";
            addtime = System.DateTime.Now;
            state = 0;
            dicvalue = "";
            effectid = "";
            effect_name = "";
            controllers = "";
            action = "";
            remark = "";
        }
        #endregion

        #region Model
        /// <summary>
        /// id
        /// </summary>
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
        /// 字典‘值’
        /// </summary>
        public string dicvalue { get; set; }
        /// <summary>
        /// 功能ID
        /// </summary>
        public string effectid { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public string effect_name { get; set; }
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
        #endregion
    }
}
