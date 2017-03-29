using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathfacts
{
    class Multiplication
    {
        public void MultiplicationTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"    __  ___      ____  _       ___            __  _           
   /  |/  /_  __/ / /_(_)___  / (_)________ _/ /_(_)___  ____ 
  / /|_/ / / / / / __/ / __ \/ / / ___/ __ `/ __/ / __ \/ __ \
 / /  / / /_/ / / /_/ / /_/ / / / /__/ /_/ / /_/ / /_/ / / / /
/_/  /_/\__,_/_/\__/_/ .___/_/_/\___/\__,_/\__/_/\____/_/ /_/ 
                    /_/                                       ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will be will see the numbers between these selections be multipied.");
            Console.WriteLine("to number 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a strating number between 1 and 10");
        }

        public void MultiplicationTitle(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(string.Format("{0,6}", "n"));
                }
                else
                {
                    Console.Write(string.Format("{0,6}", i));
                }


            }

            Console.WriteLine("\n");

            for (int i = 1; i < 10; i++)
            {
                Console.Write(string.Format("{0,6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = string.Format("{0,6}", i * b);
                    Console.Write(output);

                }
                Console.WriteLine("");

            }
        }
    }
}
