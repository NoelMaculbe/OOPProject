using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Calculations
    {
        public static int CalculateAge(string birthDate, bool returnInMonths = false)
        {
       
        int age;  
  
        DateTime now = DateTime.UtcNow;  
        DateTime past = Convert.ToDateTime(birthDate);
        
        
            if (returnInMonths==true)
            {
                age = 12 * (past.Year - now.Year) + (past.Month - now.Month);
            }
            else
            {
                age = (now.Year - past.Year);
                if (now.Month < past.Month)
                    if (now.Day < past.Day)
                        age = age - 1;
            }
            return age;
        }

        public decimal CalculateInterest(decimal principalAmount, decimal monthlyRate)
        {
            decimal interest = principalAmount * (monthlyRate / 100);
            return interest;
        }
        public decimal CalculateAccruedAmount(decimal principalAmount,decimal monthlyRate, string date, int itemNum)
        {

            decimal accruedAmount = principalAmount*itemNum + (CalculateInterest(principalAmount, monthlyRate) * CalculateAge( date, true));
            
            return accruedAmount;
        }

    }
}
