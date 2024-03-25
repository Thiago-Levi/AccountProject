using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcountProject.Entities
{
    internal class SavingsAcount : Account
    {
        public double InterestRate {  get; set; }
        
        public SavingsAcount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) 
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += InterestRate * Balance; 
        }

    }
}
