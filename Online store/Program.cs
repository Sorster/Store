using System;
using System.Collections;

namespace Online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ArrayList products = new ArrayList();
            MainMenu.Menu(products);
        }
    }
}
