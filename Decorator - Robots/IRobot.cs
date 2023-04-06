using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator___Robots
{
    public interface IRobot
    {
        public IRobotStrategy Strategy { get; set; }
        int Price { get; set;}
        int Health { get; set; }
        int Defence { get; set; }
        int Attack { get; set; }
        public bool HasRunAway { get; set; }
        public bool IsDefenceActive { get; set; }
        void AttackEnemy(IRobot robot);
        void ActiveDefence();
        public void RunAway();
        public void Combat(IRobot robot);
        

    }

}
