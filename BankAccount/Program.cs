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
              "- [1] View Client Information" + Environment.NewLine);

            //Display menu options
            Console.WriteLine(menu);

            
        }
    }
}
