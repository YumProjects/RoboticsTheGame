using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RoboticsTheGame
{
    public abstract class Level
    {
        public void Sleep(double seconds)
        {
            Thread.Sleep((int)(seconds * 1000));
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Print(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                if(!char.IsWhiteSpace(str[i]))
                    Sleep(0.02);
            }
        }

        public void Print(string str)
        {
            Print(str, ConsoleColor.Gray);
        }

        public void PrintLine(string str, ConsoleColor color)
        {
            Print(str + "\n", color);
        }

        public void PrintLine(string str)
        {
            Print(str + "\n", ConsoleColor.Gray);
        }

        public void SkipLine()
        {
            Print("\n");
        }

        public void WaitForKey()
        {
            Console.ReadKey(true);
        }

        public string Prompt(string str)
        {
            Print(str + " ", ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.Gray;
            return Console.ReadLine();
        }

        public bool YesNo(string str)
        {
            while (true)
            {
                string input = Prompt(str + " [Y/N]").ToLower();
                if (input == "y") return true;
                else if (input == "n") return false;
                else PrintLine("What about '[Y/N]' don't you understand?", ConsoleColor.Red);
            }
        }

        public void YesIsWrong(string str)
        {
            while (YesNo(str))
            {
                PrintLine("Wrong.");
            }
        }

        public void NoIsWrong(string str)
        {
            while (!YesNo(str))
            {
                PrintLine("Wrong.");
            }
        }

        public int Choise(string str, params string[] choises)
        {
            PrintLine(str, ConsoleColor.Yellow);
            for(int i = 0; i < choises.Length; i++)
            {
                PrintLine((i + 1).ToString() + ". " + choises[i], ConsoleColor.White);
            }
            while (true)
            {
                string input = Prompt("> ");
            }
        }

        public abstract void Run();
    }
}