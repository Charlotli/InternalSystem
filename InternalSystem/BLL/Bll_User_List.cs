using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Data;
using InternalSystem.Data.Model;

namespace InternalSystem.Server.BLL
{
    
    public class Bll_User_List
    {
        private Dal_User_List dalUser_List=new Dal_User_List();

        public BaseResult GetAllUser_List(int page, int limit)
        {
            BaseResult result =new BaseResult();
            result.code = 0;
            result.count = dalUser_List.GetUser_ListCount();
            result.data = dalUser_List.GetUser_List(page, limit);
            return result;
        }

    }
}
