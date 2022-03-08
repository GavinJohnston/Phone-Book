using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class Controller
    {
        public static void SendData(string name, int number) {
            
            PhoneBook usr = new PhoneBook() { Name = name, Number = number };
                
            using (var ctx = new EFContext("Server=localhost,1433; Database=PhoneBook; User=sa; Password=someThingComplicated1234")) {
                ctx.Book.Add(usr);
                ctx.SaveChanges();
            }          
        }

        public static List<PhoneBook> GetData() {

            using (var ctx = new EFContext("Server=localhost,1433; Database=PhoneBook; User=sa; Password=someThingComplicated1234")) {
                
            var Data = ctx.Book.ToList();

            return Data;
            }
        }

        public static void EditName(int ID, string NewName, int NewNumber) {
            
            using (var ctx = new EFContext("Server=localhost,1433; Database=PhoneBook; User=sa; Password=someThingComplicated1234")) {

                var item = ctx.Book.Find(ID);
                if(item != null) {
                    item.Name = NewName;
                    item.Number = NewNumber;
                    ctx.SaveChanges();
                }
            }

        }

        public static void DeleteItem(int ID) {

            using (var ctx = new EFContext("Server=localhost,1433; Database=PhoneBook; User=sa; Password=someThingComplicated1234")) {

                var item = ctx.Book.Find(ID);
                if(item != null) {
                    ctx.Book.Remove(item);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
