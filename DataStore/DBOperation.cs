using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class DBOperation
    {
        private string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\source\repos\DDJJAdministrator\DataStore\DateBase\BBDDdeclaracionJurada.mdf;Integrated Security=True;Connect Timeout=30";


        public List<T> OperationQuery<T>(string sqlQuery)
        {
            List<T> LstResult;
            using (var connection = new SqlConnection(ConnectionString))
            {
                LstResult = connection.Query<T>(sqlQuery).ToList();
            }
            return LstResult;
        }

    }
}
