using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X += 1;

            }
        }
    }
}
