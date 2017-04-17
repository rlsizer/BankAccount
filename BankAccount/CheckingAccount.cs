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
        private double depositAmount;
        private double withdrawalAmount;
        private double checkingAccountBal;



        //Properties
        public double CheckingAccountBal
        {
            get { return this.checkingAccountBal; }

        }


        //Constructors
        public CheckingAccount(string accountNumber, double accountBalance, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountName = accountName;
        }

        public CheckingAccount(double depositAmount)
        {
            this.depositAmount = depositAmount;
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

        public double CalcBalance()
        {
            checkingAccountBal = accountBalance / 4;
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
            
            accountBalance += depositAmount;
            Console.WriteLine(accountBalance);
            return accountBalance;
            
        }

        public override double Withdrawal()
        {
            withdrawalAmount = Convert.ToDouble(Console.ReadLine());
            accountBalance -= withdrawalAmount;
            return withdrawalAmount;
        }

        public override double PrintNewBalance()
        {
            return base.PrintNewBalance();
        }

    }
}
