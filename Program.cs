using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool CloseApp = false;

            while(CloseApp == false) {

                Console.Clear();
                Console.WriteLine("PHONE BOOK");
                Console.WriteLine("==========\n\n");
                Console.WriteLine("Welcome! enter a number from the list below to get started or enter 0 to close the app..\n\n");
                Console.WriteLine("1. View Phone Book\n");
                Console.WriteLine("2. Add Entry\n");
                Console.WriteLine("3. Update Entry\n");
                Console.WriteLine("4. Remove Entry\n\n");

                bool Result = false;
                int MenuIndex = -1;
                string UserInput = Console.ReadLine();

                Result = int.TryParse(UserInput, out MenuIndex);

                while(Result == false || MenuIndex > 3 || MenuIndex < 0) {

                    Console.WriteLine("ERROR: Please select a number between 1 & 4, or press 0 to close the app.\n");

                    UserInput = Console.ReadLine();

                    Result = int.TryParse(UserInput, out MenuIndex);
                } 

                switch(MenuIndex) {
                     case 0:
                         Console.Clear();
                         Console.WriteLine("Closing Phone Book... Goodbye!");
                         CloseApp = true;
                     break;
                     case 1:
                         Console.Clear();
                         MenuOptions.ViewBook();
                     break;
                     case 2:
                         Console.Clear();
                         MenuOptions.AddEntry();
                     break;
                     case 3:
                         Console.Clear();
                         MenuOptions.UpdateEntry();
                     break;
                     case 4:
                         Console.Clear();
                         MenuOptions.RemoveEntry();
                     break;
               }
           }
        }
    }
}
