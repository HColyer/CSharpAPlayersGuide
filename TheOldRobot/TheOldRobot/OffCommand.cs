using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}
