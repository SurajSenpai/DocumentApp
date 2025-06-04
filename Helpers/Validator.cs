using System;

namespace Learn
{
    //validator class which validates from string to string, int and double
    public class Validator
    {
        public static string StringValidator(string input)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                System.Console.Write("Invalid Input, Re-enter: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public static int StringToIntValidator(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                System.Console.Write("Invalid Input, Re-enter: ");
                input = Console.ReadLine();
            }
            return result;
        }

        public static double StringToDoubleValidator(string input)
        {
            double result;
            while (!double.TryParse(input, out result))
            {
                System.Console.Write("Invalid Input, Re-enter: ");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}