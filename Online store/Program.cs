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
            ArrayList products = new ArrayList();
            MainMenu.Menu(products);

            string configurationParameter = ConfigurationManager.AppSettings.Get("Key0");
            Console.WriteLine($"Pi = {configurationParameter}");
            Pause.ContinueAndClear();
        }
    }
}
