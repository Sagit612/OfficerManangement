using System;
using System.Collections.Generic;
using System.Text;

namespace OfficerManagement
{
    class MenuOption
    {
        public const int INIT = 0;
        public const int ADD_OFFICERS = 1;
        public const int GET_ALL = 2;
        public const int REMOVE_STUDENT = 3;
        public const int SEARCH_BY_ID = 4;
        public const int UPDATE_ENGINEER = 5;
        public const int UPDATE_WORKER = 6;
        public const int COUNT_OFFICERS = 7;
        // TODO
        public const int SEARCH_BY_CLASS_NAME = 8;
        public const int SEARCH_BY_AGE = 9;
        public const int SEARCH_BY_MARK = 9;
        public const int EXIT = 10;

        public const string ADD_ENGINEER = "a";
        public const string ADD_WORKER = "b";
        public const string EXIT_ENTER_OFFICER = "v";
    }
    class IO
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\t\t\t\t\t=========Welcome to program=========");
            Console.WriteLine("\t\t\t\t\t====================================");
        }
        public static int EnterMenuOptions()
        {
            Console.WriteLine("\t\t\t\t|\t1: To add officer                  \t|");
            Console.WriteLine("\t\t\t\t|\t2: To show information of officier \t|");
            Console.WriteLine("\t\t\t\t|\t3: To remove officer by id         \t|");
            Console.WriteLine("\t\t\t\t|\t4: To search officer by id         \t|");
            Console.WriteLine("\t\t\t\t|\t5: To update engineer by id        \t|");
            Console.WriteLine("\t\t\t\t|\t6: To update worker by id          \t|");
            Console.WriteLine("\t\t\t\t|\t10: To exit                        \t|");
            Console.WriteLine("Enter your choice:");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterOfficer() 
        {
            Console.WriteLine("\t\t\t\t|\t   Enter \"a\" to add Engineer     \t|");
            Console.WriteLine("\t\t\t\t|\t   Enter \"b\" to add Worker       \t|");
            //Console.WriteLine("\t\t\t\t|\t   Enter \"v\" to exit       \t|");
            return Console.ReadLine();
        }
        public static int EnterId()
        {
            Console.WriteLine("Enter ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterName()
        {
            Console.WriteLine("Enter name: ");
            return Console.ReadLine();
        }
        public static int EnterAge()
        {
            Console.WriteLine("Enter age:");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterGender()
        {
            Console.WriteLine("Enter gender: ");
            return Console.ReadLine();
        }
        public static string EnterAddress()
        {
            Console.WriteLine("Enter address: ");
            return Console.ReadLine();
        }
        public static string EnterBranch()
        {
            Console.WriteLine("Enter branch: ");
            return Console.ReadLine();
        }
        public static int EnterLevel()
        {
            Console.WriteLine("Enter level:");
            return int.Parse(Console.ReadLine());
        }
        public static void ToScreen(string str)
        {
            Console.WriteLine(str);
        }
        public static void InputError()
        {
            Console.WriteLine("Invalid Input ...");
        }
        public static void ShowMessage(bool status)
        {
            if (status) Console.WriteLine("SUCCESSFUL!!!");
            else Console.WriteLine("Failed!!!");
        }
        public static void ShowNumberOfficer(int numberOfficer)
        {
            if (numberOfficer == 1)
            {
                Console.WriteLine($"There is {numberOfficer} officer");
            }
            Console.WriteLine($"There are {numberOfficer} officers");
        }
    }
}
