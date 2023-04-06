using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Robots
{
    public class RobotDecorator : IRobot
    {
        public IRobotStrategy Strategy { get; set; }
        public string? Name { get; protected set; }
        public int Price { get; set; } = 10;
        public int Health { get; set; } = 100;
        public int Defence { get; set; } = 0;
        public int Attack { get; set; } = 5;
        public bool HasRunAway { get; set; }
        public bool IsDefenceActive { get; set; }

        public RobotDecorator(IRobot robot)
        {
        }

        public void ActiveDefence()
        {
            if (Defence == 0) Console.WriteLine("No defence equipment");
            IsDefenceActive = true;
        }

        public void AttackEnemy(IRobot target)
        {
            if (target.IsDefenceActive)
            {
                target.Defence -= Attack;
                if (target.Defence < 0)
                {
                    target.Health += target.Defence;
                }
            }
            else
            {
                target.Health -= Attack;
            }
        }

        public void RunAway() => HasRunAway = true;

        public void Combat(IRobot robot)
        {
          
            Strategy.Combat(robot);
        }
    }

}
