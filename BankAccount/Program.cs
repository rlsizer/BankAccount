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
            Console.WriteLine("Hello, Mr. Lannister. Welcome to your Bank Account.\r\n");

            do
            {


                //Store menu options in a string
                string menu = ("BANK OF WESTEROS" + Environment.NewLine +
                  "----------------------------------" + Environment.NewLine +
                  "- [1] View Client Information" + Environment.NewLine +
                  "- [2] View Account Balance" + Environment.NewLine +
                  "- [3] Deposit Funds" + Environment.NewLine +
                  "- [4] Withdraw Funds" + Environment.NewLine +
                  "- [5] Exit Program" + Environment.NewLine);

                //Display menu options
                Console.WriteLine(menu);

                //Store user response in a string variable
                string menuChoice = Console.ReadLine();

                //Validate if user input anything
                while (string.IsNullOrWhiteSpace(menuChoice))
                {
                    Console.Clear();
                    //Tell user what went wrong
                    Console.WriteLine("Oops! You didn't select anything.\r\nPlease select a menu option between 1 and 5: ");

                    Console.WriteLine(menu);

                    menuChoice = Console.ReadLine();
                }

                //Declare variable to hold the converted value of menu selection
                int menuInt;

                //Convert with TryParse
                int.TryParse(menuChoice, out menuInt);


                //Validate that user made a numerical choice between 1 and 5 
                while (menuInt < 1 || menuInt > 5)
                {
                    Console.Clear();
                    //Tell user what went wrong
                    Console.WriteLine("Oops! You selected something other than a number between 1 and 5.\r\nPlease try again and make a menu selection between 1 and 5.");
                    Console.WriteLine(menu);
                    //Re-capture user response
                    menuChoice = Console.ReadLine();

                    //re-convert to an integer
                    int.TryParse(menuChoice, out menuInt);
                }

                Console.Clear();

                //Use switch case for user menu selections
                switch (menuInt)
                {


                    //When user selects option one, client information is displayed
                    case 1:

                        client1.DisplayClientInfo();
                        break;

                    //When user selects option two, display submenu so they can select checkings or savings
                    case 2:

                        //Instantiate a new object of CheckingAccount class
                        CheckingAccount checking1 = new CheckingAccount("12345", 120000000.50, "Lord Tyrion's Checking Account");

                        //Instantiate a new object of SavingsAccount class
                        SavingsAccount savings1 = new SavingsAccount("12345", 120000000.50, "Lord Tyrion's Savings Account");

                        //Store submenu in a string
                        string balanceSubMenu = ("BANK OF WESTEROS" + Environment.NewLine +
                        "----------------------------------" + Environment.NewLine +
                        "- [1] View Checking Account Balance" + Environment.NewLine +
                        "- [2] View Savings Account Balance" + Environment.NewLine);
                        Console.WriteLine(balanceSubMenu); //Display submenu to console

                        string balanceChoice = Console.ReadLine();

                        //Validate if user input anything
                        while (string.IsNullOrWhiteSpace(balanceChoice))
                        {
                            Console.Clear();
                            //Tell user what went wrong
                            Console.WriteLine("Oops! You didn't select anything.\r\nPlease select a menu option of 1 or 2: ");

                            Console.WriteLine(balanceSubMenu);

                            balanceChoice = Console.ReadLine();
                        }

                        //Declare variable to hold the converted value of menu selection
                        int balanceChoiceInt;

                        //Convert with TryParse
                        int.TryParse(balanceChoice, out balanceChoiceInt);


                        //Validate that user made a numerical choice between 1 and 5 
                        while (balanceChoiceInt < 1 || balanceChoiceInt > 2)
                        {
                            Console.Clear();
                            //Tell user what went wrong
                            Console.WriteLine("Oops! You selected something other than a number of 1 or 2.\r\nPlease try again and make a menu selection of 1 or 2.\r\n");
                            Console.WriteLine(balanceSubMenu);
                            //Re-capture user response
                            balanceChoice = Console.ReadLine();

                            //re-convert to an integer
                            int.TryParse(balanceChoice, out balanceChoiceInt);
                        }


                        if (balanceChoiceInt == 1)
                        {
                            checking1.CalcBalance();
                            checking1.ViewBalance();
                        }

                        if (balanceChoiceInt == 2)
                        {
                            savings1.CalcBalance();
                            savings1.ViewBalance();

                        }

                        break;

                    //When user selects option three, display submenu so they can select checkings or savings
                    case 3:

                        //Instantiate a new object of CheckingAccount class
                        CheckingAccount checking2 = new CheckingAccount("12345", 120000000.50, "Lord Tyrion's Checking Account");

                        //Instantiate a new object of SavingsAccount class
                        SavingsAccount savings2 = new SavingsAccount("12345", 120000000.50, "Lord Tyrion's Savings Account");

                        //Store submenu in a string
                        string depositSubMenu = ("BANK OF WESTEROS" + Environment.NewLine +
                        "----------------------------------" + Environment.NewLine +
                        "- [1] Deposit Funds into Checking Account" + Environment.NewLine +
                        "- [2] Depsoit Funds into Savings Account" + Environment.NewLine);
                        Console.WriteLine(depositSubMenu); //Display submenu to console

                        string depositChoice = Console.ReadLine();

                        //Validate if user input anything
                        while (string.IsNullOrWhiteSpace(depositChoice))
                        {
                            Console.Clear();
                            //Tell user what went wrong
                            Console.WriteLine("Oops! You didn't select anything.\r\nPlease select a menu option of 1 or 2: ");

                            Console.WriteLine(depositChoice);

                            depositChoice = Console.ReadLine();
                        }

                        //Declare variable to hold the converted value of menu selection
                        int depositChoiceInt;

                        //Convert with TryParse
                        int.TryParse(depositChoice, out depositChoiceInt);


                        //Validate that user made a numerical choice between 1 and 5 
                        while (depositChoiceInt < 1 || depositChoiceInt > 2)
                        {
                            Console.Clear();
                            //Tell user what went wrong
                            Console.WriteLine("Oops! You selected something other than a number of 1 or 2.\r\nPlease try again and make a menu selection of 1 or 2.\r\n");
                            Console.WriteLine(depositSubMenu);
                            //Re-capture user response
                            depositChoice = Console.ReadLine();

                            //re-convert to an integer
                            int.TryParse(depositChoice, out depositChoiceInt);
                        }

                        if (depositChoiceInt == 1)
                        {
                            
                            Console.WriteLine("Please enter the amount of money you wish to deposit into your checking account:\r\n");
                            string depositAmount = Console.ReadLine();

                            //Validate if user input anything
                            while (string.IsNullOrWhiteSpace(depositChoice))
                            {
                                Console.Clear();
                                //Tell user what went wrong
                                Console.WriteLine("Oops! You didn't deposit anything.\r\nPlease enter the amount you wish to deposit: ");

                                depositAmount = Console.ReadLine();
                            }

                            //Declare variable to hold the converted value of deposit amount
                            double depositAmountDouble;

                            //Convert with TryParse
                            double.TryParse(depositAmount, out depositAmountDouble);

                            CheckingAccount checking3 = new CheckingAccount(depositAmountDouble);

                            checking2.Deposit();
                        }

                        break;



                    default:
                        break;
                }

            } while (true);
        }
    }
}
