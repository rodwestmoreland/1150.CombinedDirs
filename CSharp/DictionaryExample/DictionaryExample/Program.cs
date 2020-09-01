using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Country norway = new Country("Norway", "NOR", "Europe", "5_330_000" );
            //Country country = new Country() {"Norway", "NOR", "Europe", "5_330_000"};
            //Car car1 = new Car() { Make = "BMW", Model = "750", VIN = "A3" };

            Country finland = new Country("Finland", "FIN", "Europe", "5_100_000");
            Country ustates = new Country("United States", "USA", "North America", "355_100_000");
            Dictionary<string, Country> countries = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland },
                { ustates.Code, ustates }
            };

            foreach (var country in countries.Values)
            {
                System.Console.WriteLine(country.Name);
            }
        }

    }
    class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Region { get; set; }
        public string Pop { get; set; }
        public Country(string name, string code, string region, string pop)
        {
            Name = name;
            Code = code;
            Region = region;
            Pop = pop;
        }
    }
}
