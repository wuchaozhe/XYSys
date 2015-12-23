using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentData;
using log4net;
using System.Configuration;

namespace XYSys.Service
{
    public class DbService
    {
        public static IDbContext Db() 
        {
            return Db("DefaultConnection");
        }

        public static IDbContext Db(string connectionStringName)
        {
            var log = LogManager.GetLogger(connectionStringName);
            var setting = ConfigurationManager.ConnectionStrings[connectionStringName];
            var db = new DbContext().ConnectionStringName(connectionStringName, GetProvider(setting.ProviderName));
            return db;
        }


        public static IDbProvider GetProvider(string providerName)
        {
            var providers = new Dictionary<string, IDbProvider>(){
                {"DB2",new DB2Provider()},
                {"MySql",new MySqlProvider()},
                {"Oracle",new OracleProvider()},
                {"PostgreSql",new PostgreSqlProvider()},
                {"SqlAzure",new SqlAzureProvider()},
                {"Sqlite",new SqliteProvider()},
                {"SqlServerCompact",new SqlServerCompactProvider()},
                {"SqlServer",new SqlServerProvider()}
            };
            return providers[providerName] != null ? providers[providerName] : new SqlServerProvider();
        }
    }
}
