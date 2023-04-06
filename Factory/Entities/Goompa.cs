using Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Goompa : IEnemy
    {
        public double Attact { get; set; }

        public Goompa()
        {
            Attact = 10;
        }

        public void AttactTo(Player player)
        {
            player.health -= Attact;
            Console.WriteLine("Goompa ataco al jugador");
            Console.WriteLine("La vida del player ahora es de {0}", player.health);
        }

        public void DoSpeciality()
        {
            Console.WriteLine("Goompa saltó");
        }

        public void MakeSound()
        {
            Console.WriteLine("Goompa dice: 'grrrrr'");
        }
    }

}
