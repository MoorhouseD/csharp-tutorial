using System;

namespace HelloWorld
{
    public class Bird
    {
        protected virtual void Walk()
        {
            Console.WriteLine($"{nameof(Bird)} walks");
        }
    }
}