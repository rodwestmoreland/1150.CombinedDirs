using System;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cars newCar = new Cars();
            newCar.Year = 2010;
            decimal value = newCar.DetermineMarketValue();
            Console.WriteLine(value);
            
        }

    }
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public Cars()
            {
                
            }
        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 2000)
            {
                carValue = 10000;

            } else
            {
                carValue = 2000;
            }
           
            return carValue;
        }

    }
}
