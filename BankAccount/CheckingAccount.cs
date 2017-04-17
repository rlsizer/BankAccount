using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {

        //fields
        private double interest;
        private double depositAmount;

        //Properties


        //Constructors
        public CheckingAccount(string accountNumber, double accountBalance, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountName = accountName;
        }

        //Methods
        public override double CalcInterest()
        {
            interest = 0;
            return interest;
        }

        public void PrintInterest()
        {
            Console.WriteLine("Your current interest is " + interest);
        }

        public override double ViewBalance()
        {
            Console.WriteLine("$" +accountBalance);
            return accountBalance;
        }

        public override double Deposit()
        {
            depositAmount = Convert.ToDouble(Console.ReadLine());
            accountBalance += depositAmount;
            return depositAmount;
        }

        public override double Withdrawal()
        {
            return base.Withdrawal();
        }

        public override double PrintNewBalance()
        {
            return base.PrintNewBalance();
        }

    }
}
