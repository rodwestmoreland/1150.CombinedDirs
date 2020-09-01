using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTracker
{
    interface IPayee
    {
        public void Pay();
    }
    public class Payroll
    {
        List<IPayee> payees = new List<IPayee>();
        public Payroll() 
        {
            payees.Add(new Teacher());
            payees.Add(new Principle());
        }     

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }

        }
    }
}
