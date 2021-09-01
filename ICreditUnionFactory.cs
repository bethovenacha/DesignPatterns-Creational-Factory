using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory
{
    interface ICreditUnionFactory
    {
        ISavings GetSavings(string accountNumber);
    }
}
