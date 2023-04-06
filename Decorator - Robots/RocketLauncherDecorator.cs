using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Robots
{
    public class RocketLauncherDecorator : RobotDecorator
    {
        public RocketLauncherDecorator(IRobot robot) : base(robot)
        {
            robot.Price += 50;
            robot.Attack += 15;
            Name = "Rocket Launcher";
        }
        public void FireRocket(IRobot target)
        {
            if (target.IsDefenceActive)
            {
                target.Defence -= Attack;
                if (target.Defence < 0)
                {
                    target.Health += target.Defence; 
                    target.Defence = 0;
                }
            }
            else
            {
                target.Health -= Attack;
            }
        }
    }

}
