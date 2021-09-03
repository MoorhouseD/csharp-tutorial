using System;

namespace HelloWorld
{
    public class Ball
    {
        public string Color { get; set; }
        public decimal Size { get; set; }

        public void Bounce()
        {
            Console.WriteLine($"Bounced {Color} ball, which is {Size}cm");
        }

    }
}