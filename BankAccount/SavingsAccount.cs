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
        private double newDepBal;
        private double newWithBal;


        //Properties




        //Constructors
        public SavingsAccount(string accountNumber, string accountName, double checkingAccountBal, double savingsAccountBal) : base(accountNumber,accountName,checkingAccountBal,savingsAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.checkingAccountBal = checkingAccountBal;
            this.savingsAccountBal = savingsAccountBal;
        }


        //Methods
        public override double CalcInterest()
        {
            interest = 0.05;
            return interest;
        }


        public override void ViewBalance()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance:\r\n");
            Console.WriteLine("$" + savingsAccountBal+"\r\n\r\n");
        }

        public override void Deposit(double x)
        {
            newDepBal = savingsAccountBal + x;
            Console.WriteLine("\r\nAfter the deposit, your new account balance is:\r\n\r\n" + "$" + newDepBal);
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

        public override void Withdrawal(double y)
        {
            newWithBal = savingsAccountBal - y;

            if (newWithBal >= 500)
            {
                Console.WriteLine("Your new savings account balance is: \r\n" + "$" + newWithBal);
            }

            else
            {
                Console.WriteLine("\r\nYou cannot withdraw an amount that will send the savings account below $500.\r\nPlease try again.");
            }
 
        }

        public void ViewWithBal()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance: \r\n");
            Console.WriteLine("$" + newWithBal + "\r\n\r\n");
        }

        



    }
}
