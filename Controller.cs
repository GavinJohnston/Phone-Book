using System;
using System.Data.SqlClient;

namespace PhoneBook
{
    public class Controller
    {
        public static void SendData(string name, int number) {
        
            PhoneBook usr = new PhoneBook() { Name = name, Number = number };
            
            using (var ctx = new EFContext("Server=localhost,1433; Database=PhoneBook; User=sa;Password=someThingComplicated1234"))
            {
            ctx.Book.Add(usr);
            ctx.SaveChanges();
            }          
        }

        public static void GetData() {

        }
    }
}
