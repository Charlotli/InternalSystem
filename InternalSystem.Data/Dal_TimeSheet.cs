using System;
using System.Collections.Generic;
using System.Text;
using Chloe;
using InternalSystem.Data.DB;
using InternalSystem.Entity;

namespace InternalSystem.Data
{
    public class Dal_TimeSheet
    {
        public TimeSheet GetGoOffInfo(string userid,DateTime workingDate)
        {
            using (IDbContext dbContext= DbContextFactory.CreateDbContext())
            {
                return dbContext.Query<TimeSheet>().Where(p => p.UserID == userid && p.WorkingDate == workingDate)
                    .FirstOrDefault();

            }
        }
    }
}
