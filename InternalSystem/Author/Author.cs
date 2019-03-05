using InternalSystem.Data;
using InternalSystem.Server.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Server.Author
{
   

        public class Author : ActionFilterAttribute
        {
            private Bll_Users bllUsers = new Bll_Users();
            private Dal_users dalUsers = new Dal_users();
            public bool IsCheck { get; set; }

            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                string users = filterContext.HttpContext.Session.GetString("use_server");

                if (IsCheck)
                {
                    if (users == null || users == "")
                    {
                        filterContext.Result = new RedirectResult("/Login", false);
                        return;
                    }
                    else
                    {
                       // users
                        InternalSystem.Entity.users usersobj = bllUsers.StringToObject(users);
                        if (usersobj.role != "0")
                        {
                            string result = filterContext.ActionDescriptor.DisplayName;
                            string[] array = result.Split('.');
                            string[] actionarray = array[4].Split('(');
                            string controller = array[3];
                            string action = actionarray[0].Trim();

                            if (!dalUsers.GetEffectsByUser(usersobj.id, controller, action))
                            {
                                filterContext.Result = new RedirectResult("/Login/Insufficient", false);
                                return;
                            }
                        }
                    }
                }
            }
        }
    
}
