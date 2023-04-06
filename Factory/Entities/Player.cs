using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities
{
    internal class Player
    {
        public double health { get; set; }
        public Player()
        {
            health = 100;
        }
    }
}
