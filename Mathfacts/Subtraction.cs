using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathfacts
{
    class Subtraction
    {
        public void SubtractionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"   _____       __    __                  __  _           
  / ___/__  __/ /_  / /__________ ______/ /_(_)___  ____ 
  \__ \/ / / / __ \/ __/ ___/ __ `/ ___/ __/ / __ \/ __ \
 ___/ / /_/ / /_/ / /_/ /  / /_/ / /__/ /_/ / /_/ / / / /
/____/\__,_/_.___/\__/_/   \__,_/\___/\__/_/\____/_/ /_/ 
                                                         ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will be will see the numbers between these selections be subtracted");
            Console.WriteLine("to number 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a strating number between 1 and 10");
        }

        public void SubtractionTitle(int startNum, int endNum)
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
                    string output = string.Format("{0,6}", i - b);
                    Console.Write(output);

                }
                Console.WriteLine("");

            }
        }
    }
}
