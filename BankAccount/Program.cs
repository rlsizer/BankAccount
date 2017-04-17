using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bank Account Project
            //Ryan Sizer
            //Week 3 - 04/17/2017


            Client client1 = new Client();

            //client1.DisplayClientInfo();


            //Greet the user
            Console.WriteLine("Hello. Welcome to your Bank Account.\r\n");

            //Store menu options in a string
            string menu = ("----------------------------------" + Environment.NewLine +
              "- [1] View Client Information" + Environment.NewLine+
              "- [2] View Account Balance" + Environment.NewLine+
              "- [3] Deposit Funds"+ Environment.NewLine+
              "- [4] Withdraw Funds"+Environment.NewLine+
              "- [5] Exit Program" + Environment.NewLine);

            //Display menu options
            Console.WriteLine(menu);

            //Store user response in a string variable
            string menuChoice = Console.ReadLine();

            //Validate if user input anything
            while (string.IsNullOrWhiteSpace(menuChoice))
            {
                //Tell user what went wrong
                Console.WriteLine("Oops! You didn't select anything.\r\nPlease select a menu option between 1 and 5: ");

                menuChoice = Console.ReadLine();
            }



            
        }
    }
}
