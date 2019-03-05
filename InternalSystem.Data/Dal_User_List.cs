using Chloe;
using InternalSystem.Data.DB;
using InternalSystem.Data.Model;
using InternalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InternalSystem.Data
{
    public class Dal_User_List
    {
        //public BaseResult Login(string username,string password)
        //{
        //    BaseResult result = BaseResult.Fail();
        //    using (IDbContext dbContext=DbContextFactory.CreateDbContext())
        //    {
        //        var count =dbContext.Query<User_List>().Where(p=>p.Password==username&&p.w)
        //    }
        //}

        /// <summary>
        /// 获取urser_list 的用户数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<User_List> GetUser_List(int page, int limit)
        {
            using (IDbContext dbContext=DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<User_List>().Where(p => p.pk_User > 0)
                    .TakePage(page, limit).ToList();
            }
        }

        public int GetUser_ListCount()
        {
            using (IDbContext dbContext=DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<User_List>().Where(p=>p.pk_User>0).Count();
            }
        }

    }
}