using System;
using System.Timers;

namespace TimerEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Start();
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"timer: {e.SignalTime:HH:mm:ss.ffff}");
        }
    }
}
