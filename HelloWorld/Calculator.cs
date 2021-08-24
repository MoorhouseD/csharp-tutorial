using System;

namespace HelloWorld
{
    public class Calculator
    {
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public decimal Subtract(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public decimal Multiply(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public decimal Divide(decimal number1, decimal number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }

            return number1 / number2;
        }

        public decimal Percentage(decimal number, int percentage = 1)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid percentage");
                return number;
            }

            decimal decPercentage = percentage / 100;

            return decPercentage * number;
        }

        public int Remainder(int number1, int number2)
        {
            return number1 % number2;
        }

    }
}