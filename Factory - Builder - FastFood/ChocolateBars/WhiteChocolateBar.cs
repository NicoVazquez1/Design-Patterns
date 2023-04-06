using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Builder___FastFood.ChocolateBars
{
    internal class WhiteChocolateBar : ChocolateBar
    {
        public override string Name { get; set; } = "Barra de chocolate blanco";
        public override string Type { get;set; } = "Chocolate blanco";
        public override int Price { get; set; } = 50;
        public override string Ingredients { get; set; } = "canela, azucar, más canela";
    }
}
