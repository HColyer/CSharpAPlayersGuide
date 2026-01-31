using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class OffCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}
