using System;

namespace classesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("rod",100);
            account.MakeWithdrawal(100, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            Console.WriteLine($"Owner: {account.Owner }, account number {account.Number } ");
            Console.WriteLine(account.GetAccountHistory());
            ////try
            //{
            //    var invalidInitBalance = new BankAccount("what",-500);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("negative balance - invalid");
            //    Console.WriteLine(e.ToString());

            //}
            //try
            //{
            //    account.MakeWithdrawal(800, DateTime.Now, "overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("illegal withdrawal");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
