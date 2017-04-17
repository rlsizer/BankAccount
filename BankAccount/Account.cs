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
        protected double accountBalance;
        protected string accountName;

        //Properties
        public string AccountNumber
        {
            get { return this.accountNumber; }

        }

        public double AccountBalance
        {
            get { return this.accountBalance; }

        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        //Constructors
        public Account()
        {

        }

        public Account(string accountNumber, double accountBalance, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountName = accountName;
        }

        //Methods
        public virtual void ViewBalance()
        {
            Console.WriteLine(accountBalance);
        }

        public virtual double Deposit()
        {
            return accountBalance;
        }

        public virtual double Withdrawal()
        {
            return accountBalance;
        }

        public virtual double PrintNewBalance()
        {
            return accountBalance;
        }
        
        public abstract double CalcInterest();




    }
}
