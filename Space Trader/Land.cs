using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class Land
    {
        public void Earth()
        {

            var oldPositionLeft = Console.CursorLeft;
            var oldPositionTop = Console.CursorTop;

            new Counter().Run();

            Console.SetCursorPosition(0, 7);

            Console.WriteLine("Great Job!!! You made it to Earth Safely!!!   \n" +
                              "You have gained $$$ for trading your resource!\n" +
                              "                                              \n" +
                              "PRESS ENTER TO CONTINUE                         ");

            Console.ReadLine();

            Console.SetCursorPosition(0, 7);

            Console.WriteLine("          *                             *       \n" +
                              "                                *               \n" +
                              "             *                                  \n" +
                              " *                         *               *    \n");

            Console.SetCursorPosition(oldPositionLeft, oldPositionTop);

        }
       
    }
}
