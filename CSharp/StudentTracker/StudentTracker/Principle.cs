using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTracker
{
    class Principle : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("pay principle");
        }
    }
}
