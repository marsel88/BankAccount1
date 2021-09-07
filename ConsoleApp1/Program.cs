using System;  

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc2 = new Account();
            acc.Balance = 2000;
            acc2.Balance = 7000;
            Operations.ShowBalance(acc);
            Operations.ShowBalance(acc2);

            Operations.Transaction(acc, acc2, 500);
            
            Operations.Witdraw(acc, 600);

            
        }
    }
}
