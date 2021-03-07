using Henxun.Cms.Core.Models;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Henxun.Cms.Core.DbHelper
{
    public class ConnectionFactory
    {
        public static IDbConnection CreateConnection(string dbType, string strCon)
        {
            if (string.IsNullOrWhiteSpace(dbType))
                throw new ArgumentException("数据类型为空");

            if (string.IsNullOrWhiteSpace(strCon))
                throw new ArgumentException("连接字符串为空");

            var databaseType = GetDataBaseType(dbType);

            return CreateConnection(databaseType, strCon);
        }

        public static DataBaseType GetDataBaseType(string dbType)
        {
            if (string.IsNullOrWhiteSpace(dbType))
                throw new ArgumentException("参数为空");

            DataBaseType result = DataBaseType.SqlServer;
            foreach (DataBaseType item in Enum.GetValues(typeof(DataBaseType)))
            {
                if (item.ToString().Equals(dbType))
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        public static IDbConnection CreateConnection(DataBaseType databaseType, string strCon)
        {
            if (string.IsNullOrWhiteSpace(strCon))
                throw new ArgumentException("连接字符串错误");

            IDbConnection dbConnection;
            switch (databaseType)
            {
                case DataBaseType.SqlServer:
                    dbConnection = new SqlConnection(strCon);
                    break;
                case DataBaseType.MySQL:
                    dbConnection = new MySqlConnection(strCon);
                    break;
                case DataBaseType.SQLite:
                    dbConnection = new SqliteConnection(strCon);
                    break;
                default:
                    throw new ArgumentException($"暂不支持的数据库类型:{databaseType.ToString()}");
            }
            return dbConnection;
        }
    }
}
