using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Ifs -------
            //CadmansIfs();

            //-----Loops Below -------

            //While loop
            //CadmansWhile();

            // Do While loop
            //CadmansMoneyCountdown();

            // For loop
            //CadmansMoneyShots();

            // ------- Classes & Methods ------- //

            //Calculator 

            Calculator calc = new Calculator();

            decimal additionTotal = calc.Add(1, 2);
            decimal sutractTotal = calc.Subtract(1, 2);
            decimal multiplyTotal = calc.Multiply(1, 2);
            decimal divideTotal = calc.Divide(1, 2);
            decimal percentageTotal = calc.Percentage(100.00m, 10);
            int remainder = calc.Remainder(8, 3);


            // The Bird & The Penguin


        }

        static void CadmansIfs()
        {
            var c = 'b';
            string a = "abc09090";
            int b = 0;
            decimal d = 0.0m;
            bool e = false;

            //If, if else, else statement
            if (c == 'a')
            {
                Console.WriteLine("a");
            }
            else if (c == 'b')
            {
                Console.WriteLine('b');
            }
            else
            {
                Console.WriteLine("Not a");
            }
        }

        static void CadmansWhile()
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine(count);
                count = count + 1;
            }
        }

        static void CadmansMoneyCountdown()
        {
            int cadmansMoney = 900;
            int itemPrice = 100;
            Console.WriteLine("Cadman's Money Spending");
            do
            {
                //Spend
                cadmansMoney = cadmansMoney - itemPrice;
                Console.WriteLine(cadmansMoney);
            }
            while (cadmansMoney > 99);
            Console.WriteLine(cadmansMoney);
        }

        static void CadmansMoneyShots()
        {
            int moneyShots = 0;
            for (int i = 0; i < 10; i += 1)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("Money Shots: " + moneyShots);
                moneyShots = moneyShots + i;
            }
        }

        static decimal Percentage(decimal originalAmount = 0, int percentage = 0)
        {
            return 0;
        }

    }
}
