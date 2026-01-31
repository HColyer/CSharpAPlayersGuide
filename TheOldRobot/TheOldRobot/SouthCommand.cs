using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y -= 1;

            }
        }
    }
}
