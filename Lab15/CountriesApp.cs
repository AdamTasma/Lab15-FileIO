using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesApp
    {
        public static void StartProgram()
        {
            Console.WriteLine("What would you like to do? (please enter '1', '2', or '3')");
            Console.WriteLine("1) List out the current countries.");
            Console.WriteLine("2) Enter a new country.");
            Console.WriteLine("3) Exit the program.");
            UserChooses();

        }
        public static void UserChooses()
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CountriesTextFile.ReadTheFile();
                        break;
                    case 2:
                        CountriesTextFile.WriteTheFile();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("that was not a valid option, please re-input.");
                        UserChooses();
                        break;
                }
            }
            else
            {
                Console.WriteLine("that was not a valid option, please re-input");
                UserChooses();
            }
        }
    }
}
