using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //fields
        private string realName = "Tyrion Lannister";
        private string mailingAddress = "1 Palace Avenue\r\nKings Landing,\r\nThe Crownlands 01001";
        private string phoneNumber = "001-237-5555";
        private string userName = "TheLordTyrion";
        private string email = "TyrionLannister@gmail.com";

        //Properties
        public string RealName
        {
            get { return this.realName; }
            
        }

        public string MailingAddress
        {
            get { return this.mailingAddress; }

        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }

        }

        public string UserName
        {
            get { return this.userName; }

        }
        public string Email
        {
            get { return this.email; }

        }

        //Constructors
        public Client()
        {

        }

        public Client(string realName, string mailingAddress, string phoneNumber, string userName, string email)
        {
            this.realName = realName;
            this.mailingAddress = mailingAddress;
            this.phoneNumber = phoneNumber;
            this.userName = userName;
            this.email = email;
        }

        //Methods
        public void DisplayClientInfo()
        {
            Console.WriteLine("**CLIENT INFORMATION** \r\n\r\n");
            Console.WriteLine("Name: " + realName+"\r\n");
            Console.WriteLine("Mailing Address: "+ mailingAddress + "\r\n");
            Console.WriteLine("Phone Number: " + phoneNumber + "\r\n");
            Console.WriteLine("Username: " + userName + "\r\n");
            Console.WriteLine("Email: " + email + "\r\n");

        }



    }
}
