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
        private double transactionAmount;
        private double checkingAccountBal;
        private double newDepBal;
        private double newWithBal;



        //Properties
        public double CheckingAccountBal
        {
            get { return this.checkingAccountBal; }

        }


        //Constructors
        public CheckingAccount(string accountNumber, string accountName, double totalAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.totalAccountBal = totalAccountBal;
        }

        public CheckingAccount(double transactionAmount)
        {
            this.transactionAmount = transactionAmount;
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

        public double DefaultCheckingBal()
        {
            checkingAccountBal = 300;
            return checkingAccountBal;
        }

        public override void ViewBalance()
        {

            Console.WriteLine();
            Console.WriteLine("Checking Account Balance: \r\n");
            Console.WriteLine("$" +checkingAccountBal+"\r\n\r\n");
  
        }

        public override double Deposit()
        {
            
            newDepBal = checkingAccountBal + transactionAmount;
            return newDepBal;
            
        }
        
        public void ViewDepBal()
        {
            Console.WriteLine();
            Console.WriteLine("Checking Account Balance: \r\n");
            Console.WriteLine("$" + newDepBal + "\r\n\r\n");
        }

        public override double Withdrawal()
        {
            newWithBal = checkingAccountBal - transactionAmount;
            return newWithBal;
        }

        public void ViewWithBal()
        {
            Console.WriteLine();
            Console.WriteLine("Checking Account Balance: \r\n");
            Console.WriteLine("$" + newWithBal + "\r\n\r\n");
        }

        public void PrintDepBalance()
        {
 
            Console.WriteLine("\r\n\r\nAfter the deposit, your new balance is: \r\n"+"$"+newDepBal);
        }

        public void PrintWithBalance()
        {
            Console.WriteLine("\r\n\r\nAfter the withdrawal, your new balance is: \r\n" + "$" + newWithBal);
        }

    }
}
