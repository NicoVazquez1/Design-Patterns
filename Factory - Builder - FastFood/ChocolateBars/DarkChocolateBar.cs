using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory___Builder___FastFood.ChocolateBars
{
    internal class DarkChocolateBar : ChocolateBar
    {
        public string Name { get; private set; } = "Barra de chocolate negro";
        public string Type { get; private set; } = "Chocolate negro";
        public int Price { get; private set; } = 60;
        public string Ingredients { get; private set; } = "canela, chocolate, azucar";
    }
}
