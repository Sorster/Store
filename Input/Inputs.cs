using System;

namespace Inputs
{
    public class NumbersInput
    {
        public static int Integer(string inputName)
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number)) break;
                else
                {
                    Console.WriteLine("Error! Rewrite number!");
                    Console.Write($"{inputName}: ");
                }
            } while (true);

            return number;
        }

        public static double Double(string inputName)
        {
            double number;
            do
            {
                if (double.TryParse(Console.ReadLine(), out number)) break;
                else
                {
                    Console.WriteLine("Error! Rewrite number!");
                    Console.Write($"{inputName}: ");
                }
            } while (true);

            return number;
        }
    }

    public class StringInput
    {
        public static string InputStringWithLettersOnly(string inputName)
        {
            string text;
            do
            {
                text = Console.ReadLine();
                if (IsLettersInStringOnly(text)) break;
                else
                {
                    Console.WriteLine("Error! Input an info again!");
                    Console.Write($"{inputName}: ");
                }
            } while (true);
            return text;
        }

        private static bool IsLettersInStringOnly(string text)
        {
            bool isLettersOnly = true;
            for (int i = 0; i < text.Length - 1; i++)
            {
                bool isDigit = Char.IsDigit(text[i]);
                if (isDigit)
                {
                    isLettersOnly = false;
                    break;
                }
            }
            return isLettersOnly;
        }
    }
}