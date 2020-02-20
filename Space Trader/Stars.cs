using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Trader
{
    class Stars
    {
        public void Draw()
        {
            Console.SetWindowSize(200, 50);

            Random rnd = new Random();  //Generates random number for star creation ("Draw" method).


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
