using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb; 
using Dapper;

namespace POM1.DataAccess
{
    class TestDataAccess
    {
        public static string TestDataFileConnection()
        {
            var FileName = ConfigurationManager.AppSettings["TestDataSheetPath"];

            var Connection = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}; Extended Properties=""Excel 12.0 Xml;HDR=YES""",FileName);

            return Connection;
        }

        public static UserData GetTestData(string KeyName)
        {
            using(var Connection=new OleDbConnection(TestDataFileConnection()))
            {
                Connection.Open();
                var query = string.Format("select * from [LogInData$] where key = '{0}' ", KeyName);
               
                var Value = Connection.Query<UserData>(query).FirstOrDefault();
                Connection.Close();
                return Value;
            }
            
        }
    }
}
