using System;

using Contract;
namespace Taxation
{
    public class Tax
    {
        public static void PayITax(IAccount acct, double amount)
        {
            acct.Balance -= amount;
            Console.WriteLine("Income Tax of Rs." + amount.ToString()+ " is applied..and your balance is Rs." + acct.Balance.ToString());
          
        }
        public static void PaySalesTax(IAccount acct, double amount)
        {
            acct.Balance -= amount;
            Console.WriteLine("Income Tax of Rs." + amount.ToString() + " is applied..and your balance is Rs." + acct.Balance.ToString());
        }
        public static void PayServiceTax(IAccount acct, double amount)
        {
            acct.Balance -= amount;
            Console.WriteLine("Income Tax of Rs." + amount.ToString() + " is applied..and your balance is Rs." + acct.Balance.ToString());
        }
        public static void PayGST(IAccount acct, double amount)
        {
            acct.Balance -= amount;
            Console.WriteLine("Income Tax of Rs." + amount.ToString() + " is applied..and your balance is Rs." + acct.Balance.ToString());
        }
        public static void PayProfessionalTax(IAccount acct, double amount)
        {
            acct.Balance -= amount;
            Console.WriteLine("Income Tax of Rs." + amount.ToString() + " is applied..and your balance is Rs." + acct.Balance.ToString());
        }
    }
}
