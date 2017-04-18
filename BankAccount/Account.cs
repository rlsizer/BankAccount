using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        //fields
        protected string accountNumber;
        protected string accountName;
        protected double checkingAccountBal;
        protected double savingsAccountBal;
        

        //Properties
        public string AccountNumber
        {
            get { return this.accountNumber; }

        }


        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        public double CheckingAccountBal
        {
            get { return this.checkingAccountBal; }
            set { this.checkingAccountBal = value; }
        }

        public double SavingsAccountBal
        {
            get { return this.savingsAccountBal; }
            set { this.savingsAccountBal = value; }
        }

        //Constructors
        public Account()
        {

        }

        public Account(string accountNumber, string accountName, double checkingAccountBal, double savingsAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.checkingAccountBal = checkingAccountBal;
            this.savingsAccountBal = savingsAccountBal;
        }

        //Methods
        public virtual void ViewBalance()
        {
            Console.WriteLine("\r\nThe grand total balance of all accounts is: \r\n\r\n");
            Console.WriteLine("$" + (checkingAccountBal + savingsAccountBal));
        }

        public virtual void Deposit(double x)
        {
            
            Console.WriteLine("\r\nThe grand total balance of your accounts is:\r\n\r\n" + (checkingAccountBal + savingsAccountBal));
        }

        public virtual void Withdrawal(double y)
        {
            Console.WriteLine("\r\nThe grand total balance of your accounts is:\r\n\r\n"+(checkingAccountBal+savingsAccountBal));
        }

        
        
        public abstract double TransactionFee();




    }
}
