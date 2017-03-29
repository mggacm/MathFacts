using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathfacts
{
    class Addition
    {
        public void AdditionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"    ___       __    ___ __  _                ______      __    __   
   /   | ____/ /___/ (_) /_(_)___  ____     /_  __/___ _/ /_  / /__ 
  / /| |/ __  / __  / / __/ / __ \/ __ \     / / / __ `/ __ \/ / _ \
 / ___ / /_/ / /_/ / / /_/ / /_/ / / / /    / / / /_/ / /_/ / /  __/
/_/  |_\__,_/\__,_/_/\__/_/\____/_/ /_/    /_/  \__,_/_.___/_/\___/ 
                                                                    ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will be will see the numbers between these selections be assed");
            Console.WriteLine("to number 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a strating number between 1 and 10");
        }

        public void AdditionTitle(int startNum, int endNum)
        {
            //TODO - build out the logic of adddition table here
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
                    string output = string.Format("{0,6}", i + b);
                    Console.Write(output);
                    
                 }
                Console.WriteLine("");

            }
        }
    }
}
