using Factory___Builder___FastFood.ChocolateBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Builder___FastFood.ChocolateBarFactories
{
    internal interface IChocolateBarFactory
    {
        public ChocolateBar CreateChocolateBar();
    }
}
