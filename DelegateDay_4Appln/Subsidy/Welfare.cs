using System;
using Contract;
namespace Subsidy
{
    public class Welfare
    {
        public static void AddAllowance(IAccount acct, double amt)
        {
            acct.Balance += amt;
            Console.WriteLine("Added benifit : Rs." + amt);
        }
    }
}
