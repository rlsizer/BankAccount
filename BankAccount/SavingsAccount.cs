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
            savingsAccountBal += x;
            Console.WriteLine("\r\nAfter the deposit, your new account balance is:\r\n\r\n" + "$" + savingsAccountBal);
        }

        public void ViewDepBal()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account Balance: \r\n");
            Console.WriteLine("$" + savingsAccountBal + "\r\n\r\n");
        }

        public void PrintDepBalance()
        {

            Console.WriteLine("\r\n\r\nAfter the deposit, your new balance is: \r\n" + "$" + savingsAccountBal);
        }

        public override void Withdrawal(double y)
        {
            savingsAccountBal -= y;

            if (savingsAccountBal >= 500)
            {
                Console.WriteLine("You are withdrawing: \r\n" + "$" + y);
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
            Console.WriteLine("$" + savingsAccountBal + "\r\n\r\n");
        }

        public void PrintWithdrawBalance()
        {

            Console.WriteLine("\r\n\r\nAfter the withdrawal, your new balance is: \r\n" + "$" + savingsAccountBal);
            Console.WriteLine();
        }




    }
}
