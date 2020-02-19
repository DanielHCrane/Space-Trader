using System;

namespace Space_Trader
{
    class SpacePicture
    {
        Random rnd = new Random();  //Generates random number for star creation ("DrawStars" method).
        public void Draw()          //Draws Space
        {

            Console.SetWindowSize(200, 50);

            DrawStars();
            DrawVenus();
            DrawMars();
            DrawAC1();
            DrawPluto();
            DrawEarth();

            Console.SetCursorPosition(95, 25);

            
        }

        private static void DrawEarth()
        {
            Console.SetCursorPosition(100, 25);

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" -Earth");

        }

        private static void DrawVenus()
        {
            Console.SetCursorPosition(150, 15);

            Console.BackgroundColor = ConsoleColor.DarkYellow;

            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" -Venus");

        }

        private static void DrawMars()
        {
            
            Console.SetCursorPosition(20, 45);

            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" -Mars");

        }

        private static void DrawAC1()
        {
            
            Console.SetCursorPosition(190, 45);

            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" -AC1");

        }

        private static void DrawPluto()
        {
            Console.SetCursorPosition(10, 15);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" -Pluto");

        }

        private void DrawStars()
        {
            for (int y = 0; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    if (rnd.NextDouble() < 0.01)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write('*');
                    }
                }
            }
        }
    }
}
