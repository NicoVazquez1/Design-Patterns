using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Robots
{
    public interface IRobotStrategy
    {
        public string StrategyName {get; set;}
        public void Combat(IRobot robot);
    }

    public class AgresiveRobotStrategy : IRobotStrategy
    {
        private readonly IRobot _robotManager;

        public AgresiveRobotStrategy(IRobot robotManager)
        {
            _robotManager = robotManager;
        }
        public string StrategyName { get; set; } = "Agresivo";
        public void Combat(IRobot robot)
        {
            float temp = new Random().Next(10);
            if (temp > 2)
            {
                Console.WriteLine("Robot eligió Atacar con la estrategia " + StrategyName);
                _robotManager.AttackEnemy(robot);
            }
            else
            {
                Console.WriteLine("Robot eligió Atacar con la estrategia " + StrategyName);
                _robotManager.ActiveDefence();
            }
        }
    }

    public class DefensiveRobotStrategy : IRobotStrategy
    {
        private readonly IRobot _robotManager;
        public DefensiveRobotStrategy(IRobot robotManager)
        {
            _robotManager = robotManager;
        }
        public string StrategyName { get; set; } = "Defensivo";
        public void Combat(IRobot robot)
        {
            float temp = new Random().Next(10);
            if (temp > 7)
            {
                Console.WriteLine("Robot eligió defenderse con la estrategia " + StrategyName);
                _robotManager.AttackEnemy(robot);
            }
            else
            {
                Console.WriteLine("Robot eligió defenderse con la estrategia " + StrategyName);
                _robotManager.ActiveDefence();
            }
        }
    }

    
}
