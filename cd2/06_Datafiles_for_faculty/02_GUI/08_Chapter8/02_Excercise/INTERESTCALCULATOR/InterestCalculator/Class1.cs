using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalculator
{
    public class CalculateInterest
    {
        private double years;
        private double rate;
        private double principal;
        private double interest;
        private double amount;

        public double NumberOfYears
        { 
            get
            {
                return years;
            }
            set
            {
                years = value;
            }
        
        }

        public double Interestrate
        {
            get 
            {
                    return rate;
            }
            set
            {
                    rate = value;
            }
        }

        public double Principalamount
        {
            get
            {
                    return principal;
            }
            set
            {
                    principal = value;
            }
        }

     
        public double Calculateinterest()
        {
            interest = (principal * rate * years) / 100;
            return interest;
        }

        public double Calculateamount()
        {
            amount = interest + principal;
            return amount;
        }

    }
}
