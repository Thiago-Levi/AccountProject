using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcountProject.Entities
{
    internal class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }
         
        public BusinessAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
           
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override string ToString() 
        {
            return $"{LoanLimit}";
        }
      

    }
}
