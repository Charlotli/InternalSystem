using Chloe;
using Chloe.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using Chloe.MySql;

namespace InternalSystem.Data.DB
{
    public class DbContextFactory
    {
        public static IDbContext CreateDbContext()
        {
            IDbContext context = new MsSqlContext(new SqlServerConnectionFactory());
            return context;
        }
         
        public static IDbContext MySqlCreateDbContext()
        {
            IDbContext context = new MySqlContext(new MySqlConnectionFactory());
            return context;
        }
    }
}