using System;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;

namespace Online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            MainMenu.Menu(items);

            string configurationVariable = ConfigurationManager.AppSettings.Get("Key0");
            Console.WriteLine($"Pi = {configurationVariable}");
            Console.WriteLine("Enter any key to exit the program...");
            Console.ReadKey();
        }
    }
}
