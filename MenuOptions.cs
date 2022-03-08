using System;

namespace PhoneBook
{
    public class MenuOptions
    {
        public static void ViewBook() {


        }
       public static void AddEntry() {

        Console.WriteLine("ADD ENTRY");
        Console.WriteLine("=========\n");

        Console.WriteLine("Enter a name\n");

        string name = Console.ReadLine();

        Console.WriteLine($"Enter a Number for {name}\n");

        bool Result = false;
        int number = 0;
        string UserInput = Console.ReadLine();

        Result = int.TryParse(UserInput, out number);

        while(Result == false) {

            Console.WriteLine("ERROR: must be numbers only.\n");

            UserInput = Console.ReadLine();

            Result = int.TryParse(UserInput, out number);
        }         

        Controller.SendData(name, number);

        }
       public static void UpdateEntry() {


        }
       public static void RemoveEntry() {


        }
    }
}