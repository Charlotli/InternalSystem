using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLog;

namespace InternalSystem.Server.Controllers
{
    public class LoginController : Controller
    {
        private Dal_users dalUsers = new Dal_users();

        public IActionResult Index()
        {
            //var logger = LogManager.GetCurrentClassLogger();
            //logger.Info("测试1");
            HttpContext.Session.SetString("use_server", "");
            return View();
        }

        [HttpPost]
        public JsonResult Validate(string username, string password)
        {
            var temp = dalUsers.Login(username, password);
            if (temp.code == 0)
            {
                HttpContext.Session.SetString("use_server", JsonConvert.SerializeObject(temp.data));
            }
            return Json(temp);
        }

        /// <summary>
        /// 权限不足
        /// </summary>
        /// <returns></returns>
        public IActionResult Insufficient()
        {
            return View();
        }
    }
}