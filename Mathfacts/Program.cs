using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathfacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication multiplactation = new Multiplication();
            do
            {
                MainAppTitle();
                choice = MainMenu();
                if (choice == 1)         
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;

                    do
                    {
                        addTable.AdditionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number.");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number.");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            Console.ReadLine();
                         
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.WriteLine("");
                                addTable.AdditionTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you Like more addtion facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                    

                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }
                            
                        }
 

                    } while (continueChoice == true);

                    
                }

                //Multiplication
                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        multiplactation.MultiplicationTitle();
                        try
                        {
                            Console.WriteLine("Enter your staring number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid Number");
                            Console.ReadLine();

                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                multiplactation.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Multiplication Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                multiplactation.MultiplicationTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you Like more mutiplication facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }


                                }
                                catch (Exception)
                                {

                                    throw;
                                }

                            }
                        }

                    } while (continueChoice == true);

                }



            } while (choice != 3);
        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("=================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Mutiplication Facts");
            Console.WriteLine("Option 3: Quit Math Facts");
            //TODO - fix the exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"    __  ___      __  __       ______           __          ___              
   /  |/  /___ _/ /_/ /_     / ____/___ ______/ /______   /   |  ____  ____ 
  / /|_/ / __ `/ __/ __ \   / /_  / __ `/ ___/ __/ ___/  / /| | / __ \/ __ \
 / /  / / /_/ / /_/ / / /  / __/ / /_/ / /__/ /_(__  )  / ___ |/ /_/ / /_/ /
/_/  /_/\__,_/\__/_/ /_/  /_/    \__,_/\___/\__/____/  /_/  |_/ .___/ .___/ 
                                                             /_/   /_/      ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
