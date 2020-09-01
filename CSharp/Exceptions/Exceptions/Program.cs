using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            try
            {
                string myFile = File.ReadAllText(@"C:\_PHI\text.txt");
                Console.WriteLine(myFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found");
                Console.WriteLine($"VS found this error: {ex.Message}");
                //var userFile = Console.ReadLine();
                
            }
            finally
            {
                //application can exit
                Console.WriteLine("application will now close");
            }
            

        }
    }
    class AnotherOption
    {
        public string UserFile { get; set; }
        private static void GetUserFile()
        {
            
        }
    }
        

}
