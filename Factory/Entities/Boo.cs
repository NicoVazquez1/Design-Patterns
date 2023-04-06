using Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Boo : IEnemy
    {
        public double Attact { get; set; }

        public Boo()
        {
            Attact = 7;
        }

        public void AttactTo(Player player)
        {
            player.health -= Attact;
            Console.WriteLine("boo ataco al jugador");
            Console.WriteLine("La vida del player ahora es de {0}", player.health);
        }

        public void DoSpeciality()
        {
            Console.WriteLine("Desaparecer");
        }

        public void MakeSound()
        {
            Console.WriteLine("Boo dice: Boooooohh");
        }
    }
}
