using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticsTheGame
{
    public class MenuLevel : Level
    {
        public override void Run()
        {
            Clear();
            PrintLine("**** Robotics The Game 2020 ****", ConsoleColor.Cyan);
            PrintLine("          By Ben Hess", ConsoleColor.Yellow);
            SkipLine();
            PrintLine("Press any key to play...");
            WaitForKey();
            new Level1().Run();
        }
    }
}
