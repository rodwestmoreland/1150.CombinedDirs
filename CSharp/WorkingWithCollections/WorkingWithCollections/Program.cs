using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway","NOR","Europe","5_330_000");
            Country finland = new Country("Finland","FIN","Europe","5_100_000");
            Country ustates = new Country("United States","USA","North America","355_100_000");
            var countries = new List<country>();
            countries.Add(norway.Code,norway);
            countries.Add(finland.Code,finland);
            countries.Add(ustates.Code,ustates);
            foreach(var country in countries)
            {
                System.Console.WriteLine( countries.Code );
            }
            //Car car1 = new Car();
            //Car car2 = new Car();
            Book b1 = new Book();
            car1.Make =     "Oldsmobile";
            car1.Model =    "Supreme";
            car1.VIN =      "A1";
            car2.Make =     "Geo";
            car2.VIN =      "A2";
            car2.Model =    "Prism";
            b1.Author =     "Bob Tabor";
            b1.Title =      "Programming .Net Services";
            b1.ISBN =       "0-000-0000-0";
            //ArrayLists are dynamically sized
            //Can sort, add, remove items, etc
            //But you can also put other dissimilar items in it  - can cause problems
            //ArrayList myArrayLIst = new ArrayList();
            //myArrayLIst.Add(car1);
            //myArrayLIst.Add(car2);
            //myArrayLIst.Add(b1);
            //List<T> is the generic collection - you have to specify the data type
            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            ////myList.Add(b1); myList is assigned to Car - cannot be assiged to Book
            //foreach (Car car in myList)
            //{
            //    Console.WriteLine($"{car.Make} - {car.Model}");

            //}
            Car car1 = new Car() { Make = "BMW", Model = "750", VIN="A3" };
            Car car2 = new Car() { Make = "Toyota", Model = "Camry", VIN = "A4" };
            //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            //myDictionary.Add(car1.VIN,car1);
            //myDictionary.Add(car2.VIN,car2);
            List<Car> myList = new List<Car>()
            {
                new Car {Make="Chevy",  Model="S10",    VIN="B1" },
                new Car {Make="Ford",   Model="Ranger",    VIN="B2" }
            };

            

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
