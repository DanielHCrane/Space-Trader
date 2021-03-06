﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class Planets
    {
        public void Run()
        {
            int userInput = 0;
            int i;
            int j = 0;
            int k = 1;
            for (i = 18; i < 65; ++i)
            {
                
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
                                          "|__________________________________|\n" +
                                          "\n" +
                                          "GREAT JOB! You made it to Earth Safely!\n");

                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o* -AC1              o -Mars   |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n" +
                                          "\n" +
                                          "GREAT JOB! You made it to AC1 Safely!\n");
                    }
                    else if (userInput == 3)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o* -Pluto             |\n" +
                                          "|   o -AC1               o -Mars   |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n" +
                                          "\n" +
                                          "GREAT JOB! You made it to Pluto Safely!\n");
                    }
                    else if (userInput == 4)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o -AC1               o* -Mars  |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n" +
                                          "\n" +
                                          "GREAT JOB! You made it to Mars Safely!\n");
                    }
                    else if (userInput == 5)
                    {
                        Console.WriteLine(" __________________________________\n" +
                                          "| o -Earth                         |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o -AC1               o -Mars   |\n" +
                                          "|             o* -Venus            |\n" +
                                          "|__________________________________|\n" +
                                          "\n" +
                                          "GREAT JOB! You made it to Venus Safely!\n");
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
                    Console.WriteLine("You got too old and you died in space. Sorry ... Good-bye.");

                    Environment.Exit(0);
                }

                if (userInput == 1 && j > 7)
                {
                    Console.WriteLine(    " __________________________________\n" +
                                          "| o* -Earth                        |\n" +
                                          "|            o -Pluto              |\n" +
                                          "|   o -AC1               o -Mars   |\n" +
                                          "|             o -Venus             |\n" +
                                          "|__________________________________|\n");


                    Console.WriteLine("YOU WON!!! CONGRATULATIONS!!! You arrived at Earth with enough $$$ to buy your way to Planet Atlantis!!! Enjoy the rest of your days!!!\n" +
                        "\n" +
                        "\n" +
                        @" __  __  __   __   __  __   __  __   ____   ____   |" + "\n" +
                        @" \ \/  \/ /  |  | |  \|  | |  \|  | |____  |   _|  |" + "\n" +
                        @"  \__/\__/   |__| |_|\___| |_|\___| |____  |_|\_|  o" + "\n");

                    Environment.Exit(0);
                }

                if (userInput == 1 && (i == 28 || i == 38))
                {
                    BlackHole();
                }

                if (userInput == 1 && (i == 43 || i == 53))
                {
                    Invaders();
                }  

                if (userInput == 2 && (i == 33 || i == 48 || i == 58))
                {
                    BlackHole();
                }

                if (userInput == 2 && (i == 23 || i == 38 || i == 63))
                {
                    Invaders();
                }

                if (userInput == 3 && (i == 28 || i == 53))
                {
                    BlackHole();
                }

                if (userInput == 3 && (i == 33 || i == 58))
                {
                    Invaders();
                }

                if (userInput == 4 && (i == 23 || i == 48 || i == 63))
                {
                    BlackHole();
                }

                if (userInput == 4 && (i == 28 || i == 53))
                {
                    Invaders();
                }

                if (userInput == 5 && i == 43)
                {
                    BlackHole();
                }

                if (userInput == 5 && (i == 23 || i == 38 || i == 48 || i == 63))
                {
                    Invaders();
                }
            }

            void BlackHole()
            {
                Console.WriteLine("BLACK HOLE!!!! During your travel a black hole appeared out of nowhere ... and your spacecraft disappeared without a trace!\n" +
                        "\n" +
                        "             -----\n" +
                        "         --         --\n" +
                        "      --               --\n" +
                        "   --          *          --\n" +
                        "      --               --\n" +
                        "         --         --\n" +
                        "             -----\n" +
                        "\n" +
                        "Sorry ... Good-bye");

                Environment.Exit(0);
            }

            void Invaders()
            {
                j += -1;

                Console.WriteLine("INVADERS!!!! When you arrived at the planet, You discovered INVADERS had stolen all the planet's $$$. The planet cannot trade with you!\n" +
                        "\n" +
                        @"         --     --" + "\n" +
                        @"\/     ---O-----O---      \/" + "\n" +
                        @" --      ---------       --" + "\n" +
                        @"   ---     vvvvvv     ---" + "\n" +
                        @"       ----------------" + "\n" +
                        @"           ------" + "\n" +
                        @"         --      --" + "\n" +
                        @"       --          --" + "\n" +
                        @"     --              --" + "\n" +
                        "\n" +
                        "You will have to travel to another planet.\n" +
                        "\n" +
                        "PRESS ENTER TO CONTINUE");

                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
