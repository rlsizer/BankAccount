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
        private double depositAmount;
        private double newDepBal;

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
        public SavingsAccount(string accountNumber, string accountName, double totalAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.totalAccountBal = totalAccountBal;
        }

        public SavingsAccount(double depositAmount)
        {
            this.depositAmount = depositAmount;
        }

        //Methods
        public override double CalcInterest()
        {
            throw new NotImplementedException();
        }

        public double DefaultSavingsBal()
        {
            savingsAccountBal = 700.50;
            return savingsAccountBal;
        }

        public override void ViewBalance()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance:\r\n");
            Console.WriteLine("$" + savingsAccountBal+"\r\n\r\n");
        }

        public override double Deposit()
        {
            newDepBal = savingsAccountBal + depositAmount;
            return newDepBal;
        }

        public void ViewDepBal()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance: \r\n");
            Console.WriteLine("$" + newDepBal + "\r\n\r\n");
        }

        public void PrintDepBalance()
        {

            Console.WriteLine("\r\n\r\nAfter the deposit, your new balance is: \r\n" + "$" + newDepBal);
        }



    }
}
