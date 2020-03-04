using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticsTheGame
{
    public class Level1 : Level
    {
        public override void Run()
        {
            Clear();
            Print("So...");
            Sleep(0.8);
            PrintLine(" where do I even begin...");
            Sleep(0.8);
            SkipLine();
            Print("Deep Space was bad.");
            Sleep(0.5);
            PrintLine(" Like really bad.", ConsoleColor.Red);
            Sleep(0.5);
            PrintLine("In fact, it was so bad there wasn't even a game about it.");
            Sleep(0.8);
            PrintLine("But I would assume FIRST has fired the idiot who designed it.");
            Sleep(0.5);
            PrintLine("So now I'm back.");
            Sleep(1);
            SkipLine();
            PrintLine("But enough about me, lets talk about you.");
            Sleep(0.5);
            Print("You had to code a shooter is season, and it was a ");
            PrintLine("big fucking pain in the ass.", ConsoleColor.Red);
            Sleep(0.5);
            SkipLine();
            YesIsWrong("Do we like data tables?");
            PrintLine("Glad were on the same page.");
            WaitForKey();
        }
    }
}
