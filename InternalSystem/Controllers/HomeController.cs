using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Entity;
using InternalSystem.Server.Author;
using InternalSystem.Server.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Server.Controllers
{
    [Author.Author(IsCheck = true)]
    public class HomeController : AuthorizationController
    {
        private BLL.Bll_Users bllUsers = new Bll_Users();

        public IActionResult Index()
        {
            users usersObj = bllUsers.StringToObject(HttpContext.Session.GetString("use_server"));
            return View();
        }

        public IActionResult Console()
        {
            return View();
        }

        public IActionResult TplMessage()
        {
            return View();
        }

        public IActionResult TplNote()
        {
            return View();
        }

        public IActionResult TplTheme()
        {
            return View();
        }
    }
}