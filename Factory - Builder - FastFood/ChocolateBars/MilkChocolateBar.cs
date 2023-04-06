using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Builder___FastFood.ChocolateBars
{
    internal class MilkChocolateBar : ChocolateBar
    {
        public string Name { get; private set; } = "Barra de chocolate milka";
        public string Type { get; private set; } = "Chocolate de leche";
        public int Price { get; private set; } = 70;
        public string Ingredients { get; private set; } = "canela, chocolate, azucar, leche, sulfato";
    }
}
