using Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal interface IEnemy
    {
        double Attact { get; set; }
        void AttactTo(Player player);
        void MakeSound();
        void DoSpeciality();
    }
}
