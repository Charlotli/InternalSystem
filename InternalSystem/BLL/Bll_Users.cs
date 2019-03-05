using InternalSystem.Data;
using InternalSystem.Data.Model;
using InternalSystem.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Server.BLL
{
    public class Bll_Users
    {
        private Dal_users dalUsers = new Dal_users();

        /// <summary>
        /// 修改|添加功能信息
        /// </summary>
        /// <param name="effect"></param>
        /// <returns></returns>
        public BaseResult UpdateEffect(effect effect)
        {
            BaseResult result = BaseResult.Fail();
            result.code = 0;

            if (effect.id == 0)
            {
                if (dalUsers.RepeatEffectsNameCount(effect.name) != 0)
                {
                    result.code = -2;
                    result.msg = "名称重名";
                    return result;
                }

                if (dalUsers.AddEffects(effect) == 0)
                {
                    result.code = -2;
                    result.msg = "添加失败";
                    return result;
                }
                return result;
            }
            if (dalUsers.UpdateEffects(effect) == 0)
            {
                result.code = -2;
                result.msg = "修改失败";
                return result;
            }
            return result;
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult DelRole(int id)
        {
            BaseResult result = BaseResult.Fail();
            result.code = 0;
            var Single = dalUsers.GetSingleRole(id);
            if (dalUsers.UserHaveRole(Single.value) > 0)
            {
                result.code = -2;
                result.msg = "存在一个或多个用户使用此角色";
                return result;
            }
            if (dalUsers.DelRole(id) == 0 && dalUsers.DelRelevance(Single.value) == 0)
            {
                result.code = -2;
                result.msg = "删除失败";
                return result;
            }
            return result;
        }

        /// <summary>
        /// 修改|添加角色信息
        /// </summary>
        /// <param name="relevance"></param>
        /// <returns></returns>
        public BaseResult UpdateRole(relevance relevance)
        {
            BaseResult result = BaseResult.Fail();
            result.code = 0;
            int rolename = dalUsers.RepeatEffectName(relevance.dicvalue);
            if (relevance.id == 0)
            {
                if (rolename != 0)
                {
                    result.code = -2;
                    result.msg = "角色名重复";
                    return result;
                }
                dalUsers.AddEffect(relevance.dicvalue);
            }
            if (relevance.NotMapped != null)
            {
                if (dalUsers.UpdateDictionary(relevance.dicvalue, relevance.NotMapped) == 0 && dalUsers.DelRelevance(relevance.NotMapped) == 0)
                {
                    result.code = -2;
                    result.msg = "出错";
                    return result;
                }
            }

            string effect = relevance.effectstr;
            if (effect == null || effect == "")
            {
                return result;
            }
            string[] effectarr = effect.Split(',');
            if (!effect.Contains(","))
            {
                if (effect != "" && effect != null)
                {
                    if (dalUsers.AddRelevance(relevance.dicvalue, Convert.ToInt16(effect)) == 0)
                    {
                        result.code = -2;
                        result.msg = "添加角色失败";
                        return result;
                    }
                }

                return result;
            }

            foreach (var s in effectarr)
            {
                if (dalUsers.AddRelevance(relevance.dicvalue, Convert.ToInt16(s)) == 0)
                {
                    result.code = -2;
                    result.msg = "添加角色失败";
                    return result;
                }
            }
            return result;
        }

        /// <summary>
        /// 修改|添加用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public BaseResult UpdateUser(users user)
        {
            BaseResult result = BaseResult.Fail();

            int namercount = dalUsers.RepeatNameUser(user.name);
            int usernamecount = dalUsers.RepeatUsernameUser(user.username);
            if (user.id == 0)
            {
                if (namercount != 0)
                {
                    result.code = -2;
                    result.msg = "姓名重复";
                    return result;
                }
                if (usernamecount != 0)
                {
                    result.code = -2;
                    result.msg = "用户名重复";
                    return result;
                }
                return dalUsers.AddUser(user);
            }
            return dalUsers.UpdateUser(user);
        }

        /// <summary>
        /// 返回后台用户数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult GetAllUsers(int page, int limit)
        {
            BaseResult result = BaseResult.Fail();
            result.code = 0;
            result.count = dalUsers.GetUsersCount();
            result.data = dalUsers.GetAllUsers(page, limit);
            return result;
        }

        /// <summary>
        /// 返回所有角色数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult GetAllRole(int page, int limit)
        {
            BaseResult result = BaseResult.Fail();
            result.code = 0;
            result.count = dalUsers.GetRoleCount();
            result.data = dalUsers.GetAllRole(page, limit);
            return result;
        }

        /// <summary>
        /// 返回所有功能数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public BaseResult GetAllEffects(int page, int limit)
        {
            BaseResult result = BaseResult.Fail();
            result.code = 0;
            result.count = dalUsers.GetEffectsCount();
            result.data = dalUsers.GetAllEffects(page, limit);
            return result;
        }

        public users StringToObject(string str)
        {
            var item = JsonConvert.DeserializeObject<users>(str);
            return item;
        }
    }
}
