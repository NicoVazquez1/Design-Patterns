using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Builder___FastFood.ChocolateBars
{
    internal abstract class ChocolateBar
    {
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual int Price { get; set; }
        public virtual string Ingredients { get; set; }
    }
}
