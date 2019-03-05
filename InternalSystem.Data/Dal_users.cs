using Chloe;
using InternalSystem.Data.DB;
using InternalSystem.Data.Model;
using InternalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalSystem.Data
{
    public class Dal_users
    {
        // public static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 删除对应角色（字典）
        /// </summary>
        /// <param name="id"></param>
        public int DelRole(int id)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Delete<dictionary>(p => p.id == id);
            }
        }

        /// <summary>
        /// 添加关联 功能
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <param name="effectid"></param>
        /// <returns></returns>
        public int AddRelevance(string dicvalue, int effectid)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return (int)dbContext.Insert<relevance>(() => new relevance()
                {
                    dicvalue = dicvalue,
                    effectid = effectid
                });
            }
        }

        /// <summary>
        /// 删除关联对应所有功能
        /// </summary>
        /// <param name="dicvalue"></param>
        public int DelRelevance(string dicvalue)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Delete<relevance>(p => p.dicvalue == dicvalue);
            }
        }

        /// <summary>
        /// 返回对应用户的所有功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool GetEffectsByUser(int id, string controller, string action)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                var item = dbContext.Query<view_users_relevance>().Where(p => p.id == id && p.controllers == controller && p.action == action).Count();
                if (item == 0)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// 返回对应角色数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public dictionary GetSingleRole(int id)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                var single = dbContext.Query<dictionary>().Where(p => p.id == id).FirstOrDefault();
                if (single == null)
                {
                    dictionary dictionary = new dictionary();
                    return dictionary;
                }

                return single;
            }
        }

        /// <summary>
        /// 修改对应角色（字典）名称
        /// </summary>
        /// <param name="value"></param>
        public int UpdateDictionary(string value, string once)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Update<dictionary>(p => p.value == once, p => new dictionary()
                {
                    value = value
                });
            }
        }

        /// <summary>
        /// 获取所有角色(role)
        /// </summary>
        /// <returns></returns>
        public List<dictionary> GetAllRole(int page, int limit)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<dictionary>().Where(p => p.key.Equals("角色")).TakePage(page, limit).ToList();
            }
        }

        public int GetRoleCount()
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<dictionary>().Where(p => p.key.Equals("角色")).Count();
            }
        }

        public List<dictionary> GetRole()
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<dictionary>().Where(p => p.id > 0).ToList();
            }
        }

        /// <summary>
        /// 返回对应角色的所有功能
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <returns></returns>
        public List< view_users_relevance> GetAllEffectByValue(string dicvalue)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<view_users_relevance>().Where(p => p.dicvalue == dicvalue).ToList();
            }
        }

        /// <summary>s
        /// 判断角色下时候有对应功能
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <param name="effectid"></param>
        /// <returns></returns>
        public int IfRelevanceByRole(string dicvalue, int effectid)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<relevance>().Where(p => p.dicvalue == dicvalue && p.effectid == effectid)
                    .Count();
            }
        }

        /// <summary>
        /// 判断是否有对应角色名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RepeatEffectName(string name)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<dictionary>().Where(p => p.value == name).Count();
            }
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int AddEffect(string value)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return (int)dbContext.Insert<dictionary>(() => new dictionary()
                {
                    key = "角色",
                    value = value
                });
            }
        }

        /// <summary>
        /// 所有功能数据
        /// </summary>
        /// <returns></returns>
        public List<effect> GetAllEffects(int page, int limit)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.id > 0).TakePage(page, limit).ToList();
            }
        }

        public List<effect> GetAllEffects()
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.id > 0).ToList();
            }
        }

        public int GetEffectsCount()
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.id > 0).Count();
            }
        }

        /// <summary>
        /// 判断功能中名称||控制器||动作是否重名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RepeatEffectsNameCount(string name)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.name == name).Count();
            }
        }

        public int RepeatEffectsControllersCount(string controllers)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.controllers == controllers).Count();
            }
        }

        public int RepeatEffectsActionCount(string action)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.action == action).Count();
            }
        }

        /// <summary>
        /// 新增功能
        /// </summary>
        /// <param name="effect"></param>
        public int AddEffects(effect effect)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return (int)dbContext.Insert<effect>(() => new effect()
                {
                    name = effect.name,
                    controllers = effect.controllers,
                    action = effect.action
                });
            }
        }

        /// <summary>
        /// 修改功能
        /// </summary>
        /// <param name="effect"></param>
        public int UpdateEffects(effect effect)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Update<effect>(p => p.id == effect.id, p => new effect()
                {
                    name = effect.name,
                    controllers = effect.controllers,
                    action = effect.action
                });
            }
        }

        /// <summary>
        /// 删除功能
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult DelEffects(int id)
        {
            BaseResult result = BaseResult.Fail();
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                dbContext.Delete<effect>(p => p.id == id);
                result.code = 0;
                return result;
            }
        }

        public BaseResult UpdatePassWord(int id, string oldPassword, string password, string repassword)
        {
            BaseResult result = BaseResult.Fail();

            if (!password.Trim().Equals(repassword.Trim()))
            {
                result.code = -1;
                result.msg = "两次密码输入不一致";
                return result;
            }

            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                if (dbContext.Query<users>().Where(s => s.id == id).FirstOrDefault().password != oldPassword)
                {
                    result.code = -2;
                    result.msg = "旧密码错误";
                    return result;
                }

                var temp = dbContext.Update<users>(p => p.id == id, p => new users()
                {
                    password = repassword
                });
                if (temp == 0)
                {
                    result.code = -2;
                    result.msg = "修改失败！";
                    return result;
                }

                result.code = 0;
                result.msg = "修改成功！";
                return result;
            }
        }

        /// <summary>
        /// 查询对应id的功能
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public effect SingleEffect(int id)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<effect>().Where(p => p.id == id).FirstOrDefault();
            }
        }

        /// <summary>
        /// 重置密码“123456”
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult UpdateBasePassword(int id)
        {
            BaseResult result = BaseResult.Fail();

            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                var temp = dbContext.Update<users>(p => p.id == id, p => new users()
                {
                    password = "123456"
                });
                if (temp == 0)
                {
                    result.code = -2;
                    result.msg = "修改失败！";
                    return result;
                }

                result.code = 0;
                result.msg = "修改成功！";
                return result;
            }
        }

        /// <summary>
        /// 用户名|姓名重复判断
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RepeatNameUser(string name)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<users>().Where(p => p.name == name).Count();
            }
        }

        public int RepeatUsernameUser(string username)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<users>().Where(p => p.username == username).Count();
            }
        }

        /// <summary>
        /// 新增账号
        /// </summary>
        /// <param name="user"></param>
        public BaseResult AddUser(users user)
        {
            BaseResult result = BaseResult.Fail();

            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                result.code = 0;
                var temp = (int)dbContext.Insert<users>(() => new users()
                {
                    name = user.name,
                    username = user.username,
                    password = user.password,
                    role = user.role
                });
                if (temp == 0)
                {
                    result.code = -1;
                }

                return result;
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public BaseResult UpdateUser(users users)
        {
            BaseResult result = BaseResult.Fail();

            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                result.code = 0;
                int user = dbContext.Update<users>(p => p.id == users.id, p => new users()
                {
                    name = users.name,
                    username = users.username,
                    password = users.password,
                    role = users.role
                });
                if (user == 0)
                {
                    result.code = -1;
                }

                return result;
            }
        }

        /// <summary>
        /// 判断是否用户下是否有对应角色
        /// </summary>
        /// <param name="dicvalue"></param>
        /// <returns></returns>
        public int UserHaveRole(string dicvalue)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<users>().Where(p => p.role == dicvalue).Count();
            }
        }

        /// <summary>
        /// 修改对应账号状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public BaseResult UpdateUserState(int id, int type)
        {
            BaseResult result = BaseResult.Fail();

            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                int user = dbContext.Update<users>(p => p.id == id, p => new users()
                {
                    state = type
                });
                result.code = 0;
                if (user == 0)
                {
                    result.code = -1;
                }

                return result;
            }
        }

        /// <summary>
        /// 返回对应用户的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public users GetSingleUsers(int id)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<users>().Where(p => p.id == id).FirstOrDefault();
            }
        }

        /// <summary>
        /// 所有后台用户数据
        /// </summary>
        /// <returns></returns>
        public List<users> GetAllUsers(int page, int limit)
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<users>().Where(p => p.id > 0).OrderByDesc(s => s.addtime).TakePage(page, limit).ToList();
            }
        }

        public int GetUsersCount()
        {
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<users>().Where(p => p.id > 0).Count();
            }
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public BaseResult Login(string username, string password)
        {
            BaseResult result = BaseResult.Fail();

            using (IDbContext dbContext = DbContextFactory.MySqlCreateDbContext())
            {
                var count = dbContext.Query<users>().Where(p => p.username == username && p.password == password).FirstOrDefault();
                if (count == null)
                {
                    result.code = -1;
                    result.msg = "用户名或密码错误";
                }
                else
                {
                    result.code = 0;
                    result.data = count;
                    result.msg = "登陆成功";
                }

                return result;
            }
        }

        /// <summary>
        /// 实体查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult GetEntity(int id)
        {
            BaseResult result = BaseResult.Fail();

            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                try
                {
                    users entity = dbContext.Query<users>().Where(p => p.id == id).FirstOrDefault();
                    if (entity == null)
                    {
                        result.code = -1;
                        result.msg = "查询记录失败";
                    }
                    else
                    {
                        result.code = 0;
                        result.data = entity;
                    }
                }
                catch (Exception ex)
                {
                    //log.Error(ex);
                    result.code = -2;
                    result.msg = "查询发生错误";
                }
            }
            return result;
        }

        public BaseResult Add(users model)
        {
            BaseResult result = BaseResult.Fail();
            DateTime currentDatetime = DateTime.Now;
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                try
                {
                    dbContext.Session.BeginTransaction();
                    dbContext.Insert<users>(() => new users()
                    {
                        name = model.name,
                        username = model.username,
                        password = model.password,
                        role = model.role,
                        addtime = model.addtime,
                        state = model.state,
                    });
                    dbContext.Session.CommitTransaction();
                    result.code = 0;
                    result.msg = "添加成功";
                    //记录操作日志
                }
                catch (Exception ex)
                {
                    dbContext.Session.RollbackTransaction();
                    //log.Error(ex);
                    //记录日志 ex.Message
                    result.code = -2;
                    result.msg = "添加失败，发生错误";
                }
            }
            return result;
        }

        public BaseResult Update(users model)
        {
            BaseResult result = BaseResult.Fail();
            DateTime currentDatetime = DateTime.Now;
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                try
                {
                    dbContext.Session.BeginTransaction();
                    users entity = dbContext.Query<users>().Where(p => p.id == model.id).FirstOrDefault();
                    if (entity != null)
                    {
                        dbContext.TrackEntity(entity);
                        entity.name = model.name;
                        entity.username = model.username;
                        entity.password = model.password;
                        entity.role = model.role;
                        entity.addtime = model.addtime;
                        entity.state = model.state;
                        int effectedRows = dbContext.Update(entity);
                        result.code = 0;
                        result.msg = "修改成功";
                    }
                    else
                    {
                        result.code = -1;
                        result.msg = "修改失败，记录不存在";
                    }
                    dbContext.Session.CommitTransaction();
                    //记录操作日志
                }
                catch (Exception ex)
                {
                    dbContext.Session.RollbackTransaction();
                    // log.Error(ex);
                    //记录日志 ex.Message
                    result.code = -2;
                    result.msg = "修改失败，发生错误";
                }
            }
            return result;
        }

        /// <summary>
        /// 批量||单一删除
        /// </summary>
        /// <param name="ids">字符串数组,号分割</param>
        /// <returns></returns>
        public BaseResult Delect(string ids)
        {
            BaseResult result = BaseResult.Fail();
            DateTime currentDatetime = DateTime.Now;
            using (IDbContext dbContext = DbContextFactory.CreateDbContext())
            {
                try
                {
                    dbContext.Session.BeginTransaction();

                    // 批量操作时累计受影响行数
                    int total = 0;
                    string[] idArray = ids.Split(',');
                    foreach (string id in idArray)
                    {
                        var temId = Convert.ToInt32(id);

                        var mo = dbContext.Query<users>().Where(s => s.id == temId).FirstOrDefault();
                        if (mo.role == "0")
                        {
                            result.code = -1;
                            result.msg = "不能删除超级管理员";
                            return result;
                        }

                        users entity = new users
                        {
                            id = Convert.ToInt32(id)
                        };
                        int effectedRows = dbContext.Delete(entity);
                        if (effectedRows > 0)
                        {
                            total += effectedRows;
                        }
                    }
                    dbContext.Session.CommitTransaction();
                    result.code = 0;
                    result.msg = string.Format("操作成功，总记录：{0}，执行成功：{1}", idArray.Length, total);
                    //记录操作日志
                    // log.Info("删除datadictionary_ids=" + ids + "成功");
                }
                catch (Exception ex)
                {
                    dbContext.Session.RollbackTransaction();
                    // log.Error(ex);
                    //记录日志 ex.Message
                    result.code = -2;
                    result.msg = "删除失败，发生错误";
                }
            }
            return result;
        }
    }
}