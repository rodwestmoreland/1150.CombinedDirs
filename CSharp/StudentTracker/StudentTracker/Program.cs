using System.Collections.Generic;
using System;
using Util;
using System.Net.Sockets;

namespace StudentTracker
{
    enum School
    {
        Harvard     = 0, // assigning 0 - 2 is not necessary for a enum. It is already zero indexed
        Princeton   = 1,
        Yale        = 2
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            GetGrades();
            Payroll payroll = new Payroll();
            payroll.PayAll();
        }
        
        private static void GetGrades()
        {
            var quit = false;
            while (quit == false)
            {
                try
                {
                    var newStudent = new Student();
                    newStudent.Name = Util.Console.Ask("Student Name? ");
                    newStudent.Grade = int.Parse(Util.Console.Ask("Grade? "));
                    newStudent.School = (School)int.Parse(Util.Console.Ask("School? (0, 1, 2)"));
                    students.Add(newStudent);
                    Student.Count++;

                    System.Console.Write("Quit? (y): ");
                    var qSent = System.Console.ReadLine();
                    if (qSent == "y" || qSent == "Y")
                    { quit = true; }
                    System.Console.WriteLine($"Count = {Student.Count}");

                } catch (Exception)
                {
                    System.Console.WriteLine("invalid. try again:");
                }
            }

            foreach (var student in students)
            {
                System.Console.WriteLine($"Student: {student.Name} Grade: {student.Grade}");
            }
            Export();

            static void Export()
            {
                foreach (var student in students)
                {
                    switch (student.School)
                    {
                        case School.Harvard:
                            System.Console.WriteLine("Harvard...");
                            break;
                        case School.Princeton:
                            System.Console.WriteLine("Princeton...");
                            break;
                        case School.Yale:
                            System.Console.WriteLine("Harvard...");
                            break;
                    }

        }
                      
                    
                }
            }
    }
    class Student : Member
    {
        public static int Count;
        
        public int Grade;
        public School School;
        
        public Student()
        {
            //System.Console.WriteLine("Student Constructor");
        }
    }
    
    public class Member
    {
        public string Name;
        public string Address;
        public int Phone;
    }
}
