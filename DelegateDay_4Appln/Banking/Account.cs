using System;
using Contract;
using Policiy;
namespace Banking
{
    public class Account:IAccount
    {
        private double balance;
      
        public event Operation UnderBalance;
        public event Operation OverBalance;
         double IAccount.Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            this.balance = balance + amount;
            Monitor();
        }
        public void Withdraw(double amount)
        {
            this.balance = balance - amount;
            Monitor();
        }
        public void Monitor()
        {
            if (balance > 500000)
            {
                OverBalance(this, 5000);//To match the signature with delegate used this
            }
            else if (balance < 10000)
            {
                UnderBalance(this, 2000);
            }
        }
       public void TaxDeduction(double taxAmount)
        {
            this.balance -= taxAmount;
        }
    }
}
