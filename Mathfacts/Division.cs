using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathfacts
{
    class Division
    {
        public void DivisionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"    ____  _       _                     ______      __    __   
   / __ \(_)   __(_)________  ____     /_  __/___ _/ /_  / /__ 
  / / / / / | / / / ___/ __ \/ __ \     / / / __ `/ __ \/ / _ \
 / /_/ / /| |/ / (__  ) /_/ / / / /    / / / /_/ / /_/ / /  __/
/_____/_/ |___/_/____/\____/_/ /_/    /_/  \__,_/_.___/_/\___/ 
                                                               ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will be will see the numbers between these selections be Divided.");
            Console.WriteLine("to number 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a strating number between 1 and 10");
        }

        public void DivisionTitle(decimal startNum, decimal endNum)
        {
            for (decimal i = startNum - 1; i <= endNum; i++)
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
                for (decimal b = startNum; b <= endNum; b++)
                {
                    string output = string.Format("{0,6}", i / b);
                    Console.Write(output);

                }
                Console.WriteLine("");

            }
        }
    }
}
