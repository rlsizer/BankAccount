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
        private double interest = .05;
        private double minBalance = 500;
        private double fee;

        //Properties

        public double MinBalance
        {
            get { return minBalance; }
            set { minBalance = value; }
        }




        //Constructors
        public SavingsAccount(string accountNumber, string accountName, double checkingAccountBal, double savingsAccountBal) : base(accountNumber,accountName,checkingAccountBal,savingsAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.checkingAccountBal = checkingAccountBal;
            this.savingsAccountBal = savingsAccountBal;
        }


        //Methods
        public override double TransactionFee()
        {
            fee = savingsAccountBal - 2.50;
            return fee;
        }

        public double CalcInterest()
        {
            interest = 0.05;
            return interest;
        }


        public override void ViewBalance()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance(without interest): \r\n");
            Console.WriteLine("$" + savingsAccountBal + "\r\n\r\n");
            Console.WriteLine("Savings Account Balance(with interest):\r\n");
            Console.WriteLine("$" + (savingsAccountBal + (savingsAccountBal * interest)) + "\r\n");
        }

        public override void Deposit(double x)
        {
            savingsAccountBal += x;
            Console.WriteLine("\r\nYou are depositing:\r\n\r\n" + "$"+x);
        }

        

        public void PrintDepBalance()
        {

            Console.WriteLine("\r\n\r\nYour current balance (with interest): \r\n" + "$" + (savingsAccountBal +(savingsAccountBal * interest)));
            Console.WriteLine();
        }

        public override void Withdrawal(double y)
        {

            

            if (savingsAccountBal - y >= minBalance)
            {
                savingsAccountBal -= y;
                Console.WriteLine("You are withdrawing: \r\n" + "$" + y);
            }

            else
            {
                Console.WriteLine("\r\nYou cannot withdraw an amount that will send the savings account below $500.\r\nPlease try again.");
                
            }
 
        }

        public void PrintWithdrawBalance()
        {

            Console.WriteLine("\r\n\r\nYour current balance (with interest): \r\n" + "$" + (savingsAccountBal + (savingsAccountBal * interest)));
            Console.WriteLine();
        }




    }
}
