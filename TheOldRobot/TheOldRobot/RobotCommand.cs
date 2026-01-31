using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }
}
