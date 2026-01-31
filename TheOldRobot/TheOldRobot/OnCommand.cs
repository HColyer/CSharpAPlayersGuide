using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
}
