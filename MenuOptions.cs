using System;
using System.Collections.Generic;
using ConsoleTableExt;

namespace PhoneBook
{
    public class MenuOptions
    {
        public static void ViewBook() {

            List<PhoneBook> Data = Controller.GetData();

            Console.Clear();

            Console.WriteLine("View Phone Book");
            Console.WriteLine("===============\n");

            ConsoleTableBuilder
            .From(Data)
            .ExportAndWriteLine();

            Console.WriteLine("\nPress Any Key to return to Main Menu.\n");

            Console.ReadLine();
        }

       public static void AddEntry() {

        Console.Clear();

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

        Console.WriteLine("\nEntry Added. Press any key to return to Main Menu\n");

        Console.ReadLine();

        }
       public static void UpdateEntry() {
        
        List<PhoneBook> Data = Controller.GetData();

        Console.Clear();

        Console.WriteLine("EDIT ENTRY");
        Console.WriteLine("==========\n");        

        ConsoleTableBuilder
        .From(Data)
        .WithFormat(ConsoleTableBuilderFormat.Minimal)
        .ExportAndWriteLine();  

        Console.WriteLine("\nEnter ID of the entry you'd like to edit.\n");

        int ID = int.Parse(Console.ReadLine());

        foreach (var PhoneBook in Data)
        {
            if(ID == PhoneBook.ID) {
                Console.Clear();

                Console.WriteLine("EDIT ENTRY");
                Console.WriteLine("==========\n");    
                Console.WriteLine($"Entry:\nName: {PhoneBook.Name}\nNumber: {PhoneBook.Number}\n");

                Console.WriteLine($"Enter a new name for {PhoneBook.Name} or press ENTER to keep the same");

                string newName = Console.ReadLine();

                if(newName == "") {
                    newName = PhoneBook.Name;
                }

                Console.WriteLine($"Enter a new number for {PhoneBook.Name} or press ENTER to keep the same");

                int newNumber = 0;
                
                int.TryParse(Console.ReadLine(), out newNumber);

                if(newNumber == 0) {
                    newNumber = PhoneBook.Number;
                }

                Controller.EditName(ID, newName, newNumber);
            }
        }

        Console.WriteLine("Update Complete, Press any key to return to Main Menu");

        Console.ReadLine();
        
        }
       public static void RemoveEntry() {
        
        List<PhoneBook> Data = Controller.GetData();

        Console.Clear();

        Console.WriteLine("DELETE ENTRY");
        Console.WriteLine("============\n");        

        ConsoleTableBuilder
        .From(Data)
        .WithFormat(ConsoleTableBuilderFormat.Minimal)
        .ExportAndWriteLine();  

        Console.WriteLine("\nEnter the ID of the item you'd like to delete\n");

        int ID = Int32.Parse(Console.ReadLine());

        Controller.DeleteItem(ID);

        Console.WriteLine("\nItem Deleted. Press any key to return to Main Menu");

        Console.ReadLine();
        }
    }
}