using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Server.BLL;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Server.Controllers
{
    public class AttendanceController : Controller
    {
        private Bll_User_List bllUserList=new Bll_User_List();

        private Bll_TimeSheet bllTimeSheet=new Bll_TimeSheet();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnOff()
        {
            return View();
        }

        public JsonResult GetAllUser_ListInfo(int page,int limit)
        {
            return Json(bllUserList.GetAllUser_List(page, limit));
        }

        public JsonResult GetGpOff(string userid,DateTime workingDate)
        {
            return Json(bllTimeSheet.RutrunGoOff(userid, workingDate));
        }
    }
}