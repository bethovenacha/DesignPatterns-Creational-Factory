using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory
{
   public class NationalSavings : ISavings
    {
        public NationalSavings()
        {
            Balance = 2000;
        }
    }
}
