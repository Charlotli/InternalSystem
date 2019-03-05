using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Data;
using InternalSystem.Entity;

namespace InternalSystem.Server.BLL
{
    public class Bll_TimeSheet
    {
       private Dal_TimeSheet dalTimeSheet=new Dal_TimeSheet();
        public view_TimeSheet RutrunGoOff(string userid, DateTime workingDate)
        {
            TimeSheet timeSheet = dalTimeSheet.GetGoOffInfo(userid,workingDate);

            view_TimeSheet viewTimeSheet=new view_TimeSheet();
            viewTimeSheet.GOPunchTime = GetTime(timeSheet.GOPunchTime.ToString()).ToString("yyyy-MM-dd hh:mm:ss");
            viewTimeSheet.OffPunchTime = GetTime(timeSheet.OffPunchTime).ToString("yyyy-MM-dd hh:mm:ss");
            viewTimeSheet.OID = timeSheet.OID;

            return viewTimeSheet;
        }

        /// <summary>

        /// 时间戳转为C#格式时间

        /// </summary>

        /// <param name="timeStamp"></param>

        /// <returns></returns>

        private DateTime GetTime(string timeStamp)

        {

            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));

            long lTime = long.Parse(timeStamp + "0000000");

            TimeSpan toNow = new TimeSpan(lTime); return dtStart.Add(toNow);

        }


    }
}
