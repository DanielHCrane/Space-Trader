using System;

namespace Space_Trader
{
    class Program
    {
        static void Main(string[] args)
        {
            new Introduction().Run();

            Console.Clear();

            new StaticDisplay().Run();

            new Planets().Run();

        }
    }
}
