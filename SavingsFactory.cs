using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory
{
    public class SavingsFactory : ICreditUnionFactory
    {
        public ISavings GetSavings(string accountNumber)
        {
            if (accountNumber.Contains("CITY"))
            {
                return new CitySavings();
            }
            else if (accountNumber.Contains("NATIONAL"))
            {
                return new NationalSavings();
            }
            else {
               throw new ArgumentException("Invalid account number.");
            }
        }
    }
}
