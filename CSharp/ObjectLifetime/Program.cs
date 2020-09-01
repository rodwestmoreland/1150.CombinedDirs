using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            { Console.WriteLine("num 1-9");
                int num = Console.ReadLine();

            }
            while ();
            
            for (int i = 0; i < rows; i++)

            {      
                for (int j = 0; j < (rows+1) - (rows-i) ; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
