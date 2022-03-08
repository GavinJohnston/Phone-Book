using System;
using System.Data.SqlClient;

namespace PhoneBook
{
    public class Controller
    {
        static string connectionString = @"Server=localhost,1433; User=sa; Password=someThingComplicated1234";
        public static void GenerateDB() {
          
            using(var connection = new SqlConnection(connectionString)) {

            }
        }
    }
}
