using Chloe.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace InternalSystem.Data.DB
{
    internal class SqlServerConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connString = string.Empty;

        public SqlServerConnectionFactory()
        {
            this._connString = ConfigHelper.GetSectionValue("SQLConnectionString");
        }

        public IDbConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(this._connString);

            return conn;
        }
    }
}