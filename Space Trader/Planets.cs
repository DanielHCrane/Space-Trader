using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class Planets
    {
        
        public void Draw()
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

                new StaticDisplay().Run();



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
                                      "|__________________________________|");
                }
                else if (userInput == 4)
                {
                    Console.WriteLine(" __________________________________\n" +
                                      "| o -Earth                         |\n" +
                                      "|            o -Pluto              |\n" +
                                      "|   o -AC1               o* -Mars  |\n" +
                                      "|             o -Venus             |\n" +
                                      "|__________________________________|");
                }
                else if (userInput == 5)
                {
                    Console.WriteLine(" __________________________________\n" +
                                      "| o -Earth                         |\n" +
                                      "|            o -Pluto              |\n" +
                                      "|   o -AC1               o -Mars   |\n" +
                                      "|             o* -Venus            |\n" +
                                      "|__________________________________|");
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
    }
}
