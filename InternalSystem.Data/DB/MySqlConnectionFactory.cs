using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Chloe.Infrastructure;
using MySql.Data.MySqlClient;
namespace InternalSystem.Data.DB
{
    class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connString = string.Empty;

        public MySqlConnectionFactory()
        {
            this._connString = ConfigHelper.GetSectionValue("MySQLConnectionString");
        }
        public IDbConnection CreateConnection()
        {
            MySqlConnection conn = new MySqlConnection(this._connString);
            return conn;
        }
    }
}
