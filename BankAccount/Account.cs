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
        protected double totalAccountBal;

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

        public double TotalAccountBal
        {
            get { return this.totalAccountBal; }
        }

        //Constructors
        public Account()
        {

        }

        public Account(string accountNumber, string accountName, double totalAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.totalAccountBal = totalAccountBal;
        }

        //Methods
        public virtual void ViewBalance()
        {
            Console.WriteLine("\r\nThe grand total balance of all accounts is: \r\n\r\n");
            Console.WriteLine("$" + totalAccountBal);
        }

        public virtual double Deposit()
        {
            return totalAccountBal;
        }

        public virtual void Withdrawal()
        {
            Console.WriteLine("\r\nThe grand total balance of your accounts is:\r\n\r\n"+totalAccountBal);
        }

        
        
        public abstract double CalcInterest();




    }
}
