using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory
{
    //concrete product
   public class CitySavings : ISavings
    {
        public CitySavings()
        {
            Balance = 5000;
        }
    }
}
