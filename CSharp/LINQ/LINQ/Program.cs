using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car {Make="Chevy",      Model="S10",        StickerPrice=55000, Year=1999,  VIN="B1" },
                new Car {Make="Ford",       Model="Ranger",     StickerPrice=35000, Year=1995,  VIN="B2" },
                new Car {Make="Oldsmobile", Model="Supreme",    StickerPrice=45000, Year=1990,  VIN="A1" },
                new Car {Make="BMW",        Model="530i",       StickerPrice=65000, Year=2018,  VIN="A2" },
                new Car {Make="BMW",        Model="750",        StickerPrice=95000, Year=2017,  VIN="A3" },
                new Car {Make="Toyota",     Model="Camry",      StickerPrice=25000, Year=2010,  VIN="A4" }
            };
            //LINQ query
            //var bmws = from car in myCars
            //           orderby car.Year descending
            //           select car;

            //using var to allow .Net to figure out what the actual data type will be when using LINQ
            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           && car.Year == 2017
            //           select car;
            //LINQ method
            //var bmws = myCars.First(s => s.Make == "BMW");
            // EXAMPLE of chaining statements together
            //var bmws = myCars.OrderBy(s => s.Year).First(s => s.Make == "BMW" );

            //var bmws = myCars.Where(s => s.StickerPrice>50000); //p => p.Make (can be any character) is a Lamba expression...
            //foreach(var car in bmws)
            //{
            //Console.WriteLine($" {bmws.Year}  {bmws.Make} {bmws.Model}");
            // Console.WriteLine(myCars.TrueForAll(s => s.Year>1970)); //returns TRUE is all are > than 1970
            //myCars.ForEach(s => s.StickerPrice -= 3000); //can perform operations on data (this reduces all by $3000)
            //myCars.ForEach(s => Console.WriteLine($"{s.Year} {s.Make} {s.Model} {s.StickerPrice:C}")); // can do foreach and CW on one line
            Console.WriteLine(myCars.Sum(s => s.StickerPrice));
            //}
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public string VIN { get; set; }
    }
}
