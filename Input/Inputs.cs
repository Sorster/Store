using System;

namespace Inputs
{
    public class Input
    {
        public static int Integer()
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number)) break;
                else Console.WriteLine("Error! Rewrite number!");
            } while (true);

            return number;
        }

        public static double Double()
        {
            double number;
            do
            {
                if (double.TryParse(Console.ReadLine(), out number)) break;
                else Console.WriteLine("Error! Rewrite number!");
            } while (true);

            return number;
        }
    }
}