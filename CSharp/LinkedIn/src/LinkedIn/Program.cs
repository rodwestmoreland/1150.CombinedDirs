using System;
using System.Collections.Generic;
namespace LinkedIn
{
    class Program
    {
        static void Main(string[] args)
        {
            var listStudents = new List<Student>();
            var newStudents = new Student();
            var adding = true;
            while (adding)
            {
                System.Console.Write("Name: ");
                newStudents.Name=Console.ReadLine();
                System.Console.Write("Age: ");
                newStudents.Age=Console.ReadLine();
                System.Console.Write("Grade: ");
                newStudents.Grade=Console.ReadLine();
                System.Console.Write("Add another? y/n: ");
                var end=Console.ReadLine();
                if(end != "y")
                {adding=false;}
            }
                  System.Console.WriteLine("before for each");      
            //foreach(var student in listStudents)   
            //{
                System.Console.WriteLine($"name: {newStudents.Name}, age: {newStudents.Age}, grage: {newStudents.Grade}");
            //}
           
            Console.WriteLine($"Hello end......... ");
        }

    }
    public class Student
    {
        public string Name;
        public string Grade;
        public string Age;

    }
}
