using System;
using System.Collections.Generic;
using System.Text;

namespace TheOldRobot
{
    interface IRobotCommand
    {
        void Run(Robot robot);
    }
}
