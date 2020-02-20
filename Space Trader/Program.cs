using System;

namespace Space_Trader
{
    class Program
    {
        string userInput = Console.ReadLine(); 
        static void Main(string[] args)
        {
            new Introduction().Run();

            new Stars().Draw();

            new Planets2().Draw();

            new MoveSpacecraft().Move();

            


            //Console.Clear();

            //new StaticDisplay().Run();

            //new Planets().Run();

        }
    }
}
