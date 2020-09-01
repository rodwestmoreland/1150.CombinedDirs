using System;
using System.Diagnostics.Tracing;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = Menu();

            }
            
        }
        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("Option 3 = exit");
            string result = Console.ReadLine();

            switch(result)
            {
                case "1":
                    Console.WriteLine(" pressed 1");
                    PrintNum();
                    return true;
                case "2":
                    Console.WriteLine(" pressed 2");
                    GuessGame();
                    return true;
                case "3":
                    Console.WriteLine(" pressed 3 : Exit");
                    return false;

                default:
                    Console.WriteLine(" invalid selection");
                    return true;
            }
        }
        private static void PrintNum()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.WriteLine("Pick a number");
            var result = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= result; counter++)
            {
                var test = counter + " - ";
                Console.Write(test);
               
            }
            //Console.WriteLine(test);
            Console.ReadLine();
        }
        private static void GuessGame()
        {
            Console.WriteLine("Guessing Game");
            Random randomObject = new Random();
            int randomNum = randomObject.Next(1,11);
            

            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNum.ToString())
                {
                    incorrect = false;
                } else { Console.WriteLine("incorrect"); }

            } while (incorrect);
            Console.WriteLine($"Correct.  Took you {guesses} guesses.");
            Console.ReadLine();
        }
    }

}
