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
        public CheckingAccount(string accountNumber, string accountName, double totalAccountBal)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.totalAccountBal = totalAccountBal;
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
            
            checkingAccountBal += depositAmount;
            return checkingAccountBal;
            
        }

        public override double Withdrawal()
        {
            withdrawalAmount = Convert.ToDouble(Console.ReadLine());
            checkingAccountBal -= withdrawalAmount;
            return withdrawalAmount;
        }

        public void PrintDepBalance()
        {
            checkingAccountBal += depositAmount;
            Console.WriteLine("\r\n\r\nAfter the deposit, your new balance is: \r\n"+"$"+checkingAccountBal);
        }

    }
}
