using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class StaticDisplay
    {
        public void Run()
        {
            int inputAge = 18;
            int inputCash = 0;
            int inputRes = 1;
            Console.WriteLine($" __________________________________\n" +
                              $"|                                  |\n" +
                              $"|   Player Age:       {inputAge}           |\n" +
                              $"|   Player $$$:       {inputCash}            |\n" +
                              $"|   Player Resources: {inputRes}            |\n" +
                              $"|__________________________________|\n");
            Console.WriteLine( " __________________________________\n" +
                               "| o* -Earth                        |\n" +
                               "|            o -Pluto              |\n" +
                               "|   o -AC1               o -Mars   |\n" +
                               "|             o -Venus             |\n" +
                               "|__________________________________|\n");
        }
    }
}
