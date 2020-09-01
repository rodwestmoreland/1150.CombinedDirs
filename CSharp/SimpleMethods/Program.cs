using System;
using System.Linq;
/// <summary>
/// reference: Bob Tabor C# for absolute beginners https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners/Defining-and-Calling-Methods
/// Gives an Overloaded Method example...((not used in code below))
/// </summary>
namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first name");
            var firstName = "rodney";
            Console.WriteLine("last name");
            var lastName = "West";
            Console.WriteLine("city");
            var city = "Boise";
            
            GetResult(ReverseArray(firstName), 
                ReverseArray(lastName),
                ReverseArray(city));
        }
        private static void GetResult(string rFirstN,
            string rLastN,
            string rCityN)
        {
            Console.Write($"{rFirstN} {rLastN} {rCityN}");
        }
        private static string ReverseArray(string name)
        {
            char[] charArr = name.ToCharArray();
            Array.Reverse(charArr);
            return string.Concat(charArr);
            //var results = "";
            //foreach (var item in charArr)
            //{
            //    //results += item;
            //    Console.Write(item);
            //}
            //Console.Write(" ");
            //results += " ";
            //return results;
        }
    }
}
