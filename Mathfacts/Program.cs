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
            //DECLARING
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication multiplactation = new Multiplication();
            Division division = new Division();
            //MAIN LOOP
            do
            {   //MAIN TITILE SCREEN
                MainAppTitle();
                choice = MainMenu();
                //OPTION 1: ADDITION
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

                //OPTION 2: MULTIPLICATION
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
                                //Console.ForegroundColor = ConsoleColor.White;  //Makes the table white
                                Console.WriteLine("");
                                multiplactation.MultiplicationTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you Like more mutiplication facts [y/n]");
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

                //OPTION 3: DIVISION
                //TODO - make the decimal stop at .00
                //TODO - maybe change to subtraction
                if (choice == 3)
                {
                    bool continueChoice = true;
                    decimal startNum = 0;
                    decimal endNum = 0;
                    do
                    {
                        division.DivisionTitle();
                        try
                        {
                            Console.WriteLine("Enter your staring number.");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number.");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid Number.");
                            Console.ReadLine();

                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                division.DivisionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Division Table for {0} - {1}", startNum, endNum);
                                //Console.ForegroundColor = ConsoleColor.White;  //Makes the table white
                                Console.WriteLine("");
                                division.DivisionTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you Like more division facts [y/n]");
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

                //TODO - ABOVE ADD NEW OPTION
                //BREAK OUT
            } while (choice != 4);
        }
        //MENU
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
            Console.WriteLine("Option 3: Division Facts");
            Console.WriteLine("Option 4: Quit Math Facts");
            //TODO - fix the exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }
        //MAIN TITLE
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
