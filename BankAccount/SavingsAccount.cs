using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {

        //fields
        private double minBalance;
        private double interest;

        //Properties
        public double MinBalance
        {
            get { return this.minBalance; }

        }


        //Constructors


        //Methods
        public override double CalcInterest()
        {
            throw new NotImplementedException();
        }

    }
}
