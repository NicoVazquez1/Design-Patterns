using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decorator___Robots
{
    internal class ProtectorFieldDecorator : RobotDecorator
    {
        bool _isProtectorActive;
        public ProtectorFieldDecorator(IRobot robot) : base(robot)
        {
            Price += 30;
            Name = "Protector field";
        }

        public void ActiveProtectorField()
        {
            if (_isProtectorActive == false)
            {
                Console.WriteLine("Activating Protector field...");
                _isProtectorActive = true;
                Defence += 25;
                Attack -= 10;
            }
            else Console.WriteLine("Protector fiel is Already active");
        }

        public void DesactiveProtection()
        {
            if (_isProtectorActive)
            {
                Console.WriteLine("Desactivating Protector field...");
                _isProtectorActive = false;
                Defence -= 25;
                Attack += 10;
            }
            else Console.WriteLine("Protector fiel is not active");
        }

    }
}
