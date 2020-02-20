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
                var oldPositionLeft = Console.CursorLeft;
                var oldPositionTop = Console.CursorTop;

                DrawSpacecraft();

                Console.SetCursorPosition(oldPositionLeft, oldPositionTop);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    LandOnPlanet();

                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                }

                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                }

                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
                }

                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(Console.CursorLeft + 4, Console.CursorTop);
                }

                var newPositionLeft = Console.CursorLeft;
                var newPositionTop = Console.CursorTop;

                Console.SetCursorPosition(oldPositionLeft, oldPositionTop);

                Console.Write("    ");

                Console.SetCursorPosition(newPositionLeft, newPositionTop);

            } while (true);
        }


        public void DrawSpacecraft()
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("<{}>");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void LandOnPlanet()
        {

            if((Console.CursorLeft == 99) & (Console.CursorTop == 26))
            {
                new Land().Earth();

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            }
            

            //int venusLeft = 250;
            //int venusTop = 15;

            //int marsLeft = 20;
            //int marshTop = 45;

            //int AC1Left = 170;
            //int AC1Top = 35;

            //int plutoLeft = 10;
            //int plutoTop = 15;


        }
    }
}
