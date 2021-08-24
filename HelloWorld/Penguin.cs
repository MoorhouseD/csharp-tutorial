using System;

namespace HelloWorld
{
    public class Penguin : Bird
    {
        protected override void Walk()
        {
            Console.WriteLine($"{nameof(Penguin)} walks");
        }

        public void Swim()
        {
            Console.WriteLine($"{nameof(Penguin)} swims");
        }
    }
}