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
        private double newDepBal;
        private double newWithBal;



        //Properties
    


        //Constructors
        public CheckingAccount(string accountNumber, string accountName, double checkingAccountBal, double savingsAccountBal) : base(accountNumber, accountName, checkingAccountBal, savingsAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.checkingAccountBal = checkingAccountBal;
            this.savingsAccountBal = savingsAccountBal;
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

        

        public override void ViewBalance()
        {

            Console.WriteLine();
            Console.WriteLine("Checking Account Balance: \r\n");
            Console.WriteLine("$" +checkingAccountBal+"\r\n\r\n");
  
        }

        public override void Deposit(double x)
        {
            
            newDepBal = checkingAccountBal + x;
            Console.WriteLine("\r\nAfter the deposit, your new account balance is:\r\n\r\n" + "$" + newDepBal);
            
        }
        
        public void ViewDepBal()
        {
            Console.WriteLine();
            Console.WriteLine("Checking Account Balance: \r\n");
            Console.WriteLine("$" + newDepBal + "\r\n\r\n");
        }

        public override void Withdrawal(double y)
        {
            newWithBal = checkingAccountBal - y;

            if (newWithBal >= 0)
            {
                Console.WriteLine("Your new checking account balance is: \r\n" + "$" + newWithBal);
            }

            else
            {
                Console.WriteLine("\r\nYou have insufficient funds for this transaction.\r\nPlease try again.");
            }
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

        

    }
}
