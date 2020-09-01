using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\rodne\source\repos\collections\PopFile.csv";
            CsvReader reader = new CsvReader(filePath);
            
            Dictionary<string, Country> countries = reader.ReadCountries();
            //Console.WriteLine("Enter country code: ");
            //var whichCode = Console.ReadLine();

            //bool exists = countries.TryGetValue(whichCode, out Country country);
            //if (!exists)
            //{
            //    Console.WriteLine($"{whichCode} is not a valid code");
            //}
            //else
            //{
            //    Console.WriteLine($"{country.Code} {country.Name} {country.Region.PadLeft(20)}");
            //}
            for(int i = 0; i < countries.Count; i++)
            {
                Country country = countries[i];
                Console.WriteLine(country.Name);

            }
        }
    }
}