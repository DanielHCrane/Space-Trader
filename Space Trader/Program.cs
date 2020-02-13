using System;

namespace Space_Trader
{
    class Program
    {
        string userInput = Console.ReadLine(); 
        static void Main(string[] args)
        {
            new Introduction().Run();

            Console.Clear();

            new StaticDisplay().Run();

            new Planets().Draw();

        }
    }
}
