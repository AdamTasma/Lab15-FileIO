using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class CountriesTextFile
    {
        public static string countriesFilePath = @"C:\Users\adamt\source\repos\Lab15\Lab15\Countries.txt";
        public static void ReadTheFile()
        {
            StreamReader reader = new StreamReader(countriesFilePath, true);
            //while (true)
            //{
            //    string line = reader.ReadLine();
            //    Console.WriteLine(line);
            //    if (line == null)
            //    {
            //        //Console.WriteLine("Line is null ");
            //        break;
            //    }

            //}
            string text = reader.ReadToEnd();
            Console.WriteLine("\nCountries List \n--------------");
            Console.WriteLine(text);

            reader.Close();
            Console.WriteLine("\n \n Bringing you back to the menu.\n");
            CountriesApp.StartProgram();
        }

        public static void WriteTheFile()
        {
            Console.WriteLine("Please enter the country to add.");
            string newCountry = Console.ReadLine();

            //StreamWriter writer = new StreamWriter(countriesFilePath, true);
            using (StreamWriter writer = File.AppendText(countriesFilePath))
            {
                writer.WriteLine(newCountry);
                writer.Close();
                Console.WriteLine("\n \n Bringing you back to the menu.\n");
                CountriesApp.StartProgram();
            }
            //Console.WriteLine(writer + newCountry);


        }
    }
}
