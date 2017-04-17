using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {

        //fields
        private double minBalance;
        private double interest;
        private double savingsAccountBal;

        //Properties
        public double MinBalance
        {
            get { return this.minBalance; }

        }

        public double SavingsAccountBal
        {
            get { return this.savingsAccountBal; }

        }



        //Constructors
        public SavingsAccount(string accountNumber, double accountBalance, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountName = accountName;
        }

        //Methods
        public override double CalcInterest()
        {
            throw new NotImplementedException();
        }

        public double CalcBalance()
        {
            savingsAccountBal = accountBalance * .75;
            return savingsAccountBal;
        }

        public override void ViewBalance()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance:\r\n");
            Console.WriteLine("$" + savingsAccountBal+"\r\n\r\n");
        }

    }
}
