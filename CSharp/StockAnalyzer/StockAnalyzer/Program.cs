using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"StockData.csv");
            foreach (var line in lines.Skip(1))
            {
                var segment = line.Split(",");
                var tradeDate = DateTime.Parse(segment[1], CultureInfo.GetCultureInfo("en-GB"));
                Console.WriteLine(tradeDate );
                
            }
            Console.WriteLine("========================================");
            var formatDate = "12/10/2020 12:18:20 PM +02:00";
            //var parseDate = DateTime.ParseExact(formatDate, "M/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            //Console.WriteLine($"{ parseDate} converting string to datetime");
            Console.WriteLine("========================================");
            var parseDate = DateTime.Parse(formatDate, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
            Console.WriteLine($"{parseDate} adjusted to UTC - IF UTC offset is properly defined!");
            Console.WriteLine($"{parseDate.Kind} - parseDate.kind - not sure what practical application this has");

            // **** Ideal to conform to ISO 8601 date/time standards ***** ///
            Console.WriteLine("========================================");
            var offSet = DateTimeOffset.UtcNow;
            Console.WriteLine($"{offSet} set by UtcNow");
            Console.WriteLine($"{offSet.ToLocalTime()} Local time with UTC offset");
            Console.WriteLine("=============== TIME SPAN ========================");

            var timeInput = new TimeSpan(60, 100, 200);
            Console.WriteLine("input for TimeSpan: 60, 100, 200 =");
            Console.WriteLine($"{timeInput.Days} days");
            Console.WriteLine($"{timeInput.Hours} hours");
            Console.WriteLine($"{timeInput.Minutes} minutes");
            Console.WriteLine($"{timeInput.Seconds} seconds");
            Console.WriteLine($"{timeInput.TotalHours} Total hours");
            Console.WriteLine("=============== date time math ========================");
            var dateMathStart = DateTimeOffset.UtcNow;
            var dateMathEnd = dateMathStart.AddSeconds(45); // note: if the start var is not added here, it will be off a few milliseconds
            Console.WriteLine($"starting time: {dateMathStart} \nAdd 45 second: {dateMathEnd}");

        }
    }
}
