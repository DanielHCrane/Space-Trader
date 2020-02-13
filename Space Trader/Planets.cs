using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class Planets
    {
        public void Run()
        {
            int i;
            int j = 0;
            int k = 1;
            for (i = 18; i < 65; ++i)
            {
                int userInput = 0;
                do
                {
                    

                    Console.Write("What Planet Would You Like to Travel To:\n" +
                                      "1 = Earth\n" +
                                      "2 = AC1\n" +
                                      "3 = Pluto\n" +
                                      "4 = Mars\n" +
                                      "5 = Venus\n" +
                                      "\n" +
                                      "6 = Quit\n");

                    string input = Console.ReadLine();
                    userInput = int.Parse(input);

                    Console.Clear();

                    RunStaticDisplay();



                    if (userInput == 1)

                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o* -Earth                        |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o -AC1               o -Mars   |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n");

                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o* -AC1              o -Mars   |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n");
                    }
                    else if (userInput == 3)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o* -Pluto             |\n" +
                                          "|   o -AC1               o -Mars   |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n");
                    }
                    else if (userInput == 4)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o -AC1               o* -Mars  |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n");
                    }
                    else if (userInput == 5)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o -AC1               o -Mars   |\n" +
                                          "|             o* -Venus            |\n" +
                                          "|__________________________________|\n");
                    }
                    else if (userInput == 6)
                    {
                        Console.WriteLine("Good Bye");
                    }
                    else
                    {
                        Console.WriteLine("Choice not recognized, please select a valid planet:");
                    }
                } while (userInput != 6);

                
            }

            

            void RunStaticDisplay()
            {
                int inputAge = (i += 5);
                int inputCash = (j += 1);
                int inputRes = k;
                Console.WriteLine($" __________________________________\n" +
                                  $"|                                  |\n" +
                                  $"|   Player Age:       {inputAge}           |\n" +
                                  $"|   Player $$$:       {inputCash}            |\n" +
                                  $"|   Player Resources: {inputRes}            |\n" +
                                  $"|__________________________________|\n");

                if (i > 65)
                {
                    Console.WriteLine("You got too old and you died in space. Good-bye.");
                    Environment.Exit(0);
                }
            }
        }
        
    }
}
