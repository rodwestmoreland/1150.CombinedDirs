using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using System.Xml;
using System.Data.Entity;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarsDB>());
            InsertData();
            QueryData();
            var db          = new CarsDB();
            var cars        = ProcessCars("fuel.csv");
            var mfrs        = ProcessMfrs("manufacturers.csv");

            var query = db.Cars.OrderByDescending(c => c.Combo).Take(40);

            foreach (var car in query)
            {
                Console.WriteLine($"{ car.Mfr} == {car.Combo }");
            }
            //var xDocument   = new XDocument();                            /// *** Xml samples
            //var xCars       = new XElement("Cars",                        /// All this could be place in a separate method
            //    from car in cars
            //    select new XElement("Cars",
            //                new XAttribute("Name", car.Name),
            //                new XAttribute("Combined", car.Combo),
            //                new XAttribute("Mfr", car.Mfr))
            //        );

            //xDocument.Add(xCars);
            //xDocument.Save("fuel.xml");

            // QueryXML();

            // ****************** Using Entity
            


            // **************** end Using Entity

            //var query = cars.Where(c => c.Displacement > 5.9 && c.Cylinders > 8).OrderByDescending(c => c.Combo).ThenBy(c => c.Mfr);
            /// ** note this query method works as well
            var query2 =
                from car in cars
                join mfr in mfrs
                on car.Mfr equals mfr.Name
                orderby car.Combo descending, car.Mfr ascending
                select new //sets a new 'anonymous type'. will only pull these values into the cars query
                {
                    mfr.HQ,
                    car.Mfr,
                    car.Name,
                    car.Combo

                };
            // *** below is a join statement. Use the outer join with the smaller file size. m symbolizes the Manufacturer data source
            var query3 = cars.Join(mfrs,  
                c => c.Mfr,
                m => m.Name,
                (c, m) => new
                {
                    m.HQ,
                    c.Name,
                    c.Mfr,
                    c.Combo
                })
                .OrderByDescending(c => c.Combo)
                .ThenBy(c => c.Mfr);

            //foreach (var car in query3)
            //{
            //    Console.WriteLine($" {car.HQ} {car.Mfr} {car.Name} MPG: {car.Combo}"); //see note above about the join anonymous query
            //}
            var query4 = from car in cars
                         group car by car.Mfr;
            //foreach (var result in query4)
            //{
            //    Console.WriteLine($"{(result.Key).PadRight(35)} ||  num of cars in group: {result.Count()}");
            //}
            //foreach (var group in query4)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var car in group.OrderByDescending(c => c.Combo).Take(4))
            //    {
            //        Console.WriteLine($"{(car.Name).PadLeft(20)} {(car.Combo)}");
            //    }
            //}
            
           
        }

        private static void QueryData()
        {
            
        }

        private static void InsertData()
        {
            var eCars   = ProcessCars("fuel.csv");
            var db      = new CarsDB();
            //db.Database.Log = Console.WriteLine;
            foreach (var car in eCars)
            {
                if (!db.Cars.Any())
                {
                    db.Cars.Add(car);
                    
                }
                //db.SaveChanges(); 
            }
        }

        private static void QueryXML()
        {
            var xDocument = XDocument.Load("fuel.xml");
            var query =
                from element in xDocument.Element("Cars").Elements("Cars")
                where element.Attribute("Mfr").Value == "BMW"
                select element.Attribute("Name").Value;
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }

        private static List<Car> ProcessCars(string path)
        {
            return
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(Car.MakeCarFromCsv)  //using method to parse the csv file
                .ToList();

        }
        private static List<Manufacturer> ProcessMfrs(string path)
        {
            //return
            //    File.ReadAllLines(path)
            //    .Skip(1)
            //    .Where(line => line.Length > 1)
            //    .Select(Manufacturer.MakeMfrFromCsv)
            //    .ToList();
            // *** the code below replaces need for method in Manufacturer class and embeds query
            var query =
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(line =>
                 {
                     var columns = line.Split(',');
                     return new Manufacturer
                     {
                         Name = (columns[0]),
                         HQ = (columns[1]),
                         Year = int.Parse(columns[2])
                     };
                 });
            return query.ToList();
        }
 
    }
    public class Car
    {
        public int      Id { get; set; }
        public int      Year { get; set; }
        public string   Mfr { get; set; }
        public string   Name { get; set; }
        public double   Displacement { get; set; }
        public int      Cylinders { get; set; }
        public int      City { get; set; }
        public int      Hwy { get; set; }
        public int      Combo { get; set; }

        internal static Car MakeCarFromCsv(string line)
        {
            var columns = line.Split(',');

            return new Car
            {
                Year            = int.Parse(columns[0]),
                Mfr             = (columns[1]),
                Name            = (columns[2]),
                Displacement    = double.Parse(columns[3]),
                Cylinders       = int.Parse(columns[4]),
                City            = int.Parse(columns[5]),
                Hwy             = int.Parse(columns[6]),
                Combo           = int.Parse(columns[7])

            };
        }
    }
    public class Manufacturer
    {
        public string   Name { get; set; }
        public string   HQ { get; set; }
        public int      Year { get; set; }
        internal static Manufacturer MakeMfrFromCsv(string line) // ** not used - embedded in program class ** 
        {
            var columns = line.Split(',');
            return new Manufacturer
            {
                Name = (columns[0]),
                HQ = (columns[1]),
                Year = int.Parse(columns[2])
            };
        }
    }
}
