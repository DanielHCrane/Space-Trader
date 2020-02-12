using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class StaticDisplay
    {
        public void Run()
        {
            Console.WriteLine(" __________________________________\n" +
                              "|                                  |\n" +
                              "|   Player Age:       {inputAge}   |\n" +
                              "|   Player $$$:       {input$$$}   |\n" +
                              "|   Player Resources: {inputRes}   |\n" +
                              "|__________________________________|");

        }
    }
}
