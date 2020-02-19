using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class MoveSpacecraft
    {
        public void Move()
        {
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                }

                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                }

            } while (true);  
        }
    }
}
