using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store
{
    public class Pause
    {
        public static void ContinueAndClear()
        {
            Console.WriteLine("Inpur any key to continue the program...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
