using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    internal class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y += 1;

            }
        }
    }
}
