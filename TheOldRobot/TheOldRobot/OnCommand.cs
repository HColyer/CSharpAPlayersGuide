using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
}
