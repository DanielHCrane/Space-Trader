using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class Counter
    {
        public void Run()
        {
            int i = 18;
            int j = 0;
            int k = 1;


            Console.SetCursorPosition(0, 0);

            Console.WriteLine($" __________________________________\n" +
                              $"|                                  |\n" +
                              $"|   Player Age:       {i++}           |\n" +
                              $"|   Player $$$:       {j++}            |\n" +
                              $"|   Player Resources: {k}            |\n" +
                              $"|__________________________________|\n");

            if (i > 65)
            {
                Console.WriteLine("You got too old and you died in space. Sorry ... Good-bye.");

                Environment.Exit(0);
            }

            return;


        }
    }
}
