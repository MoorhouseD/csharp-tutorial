using System;

namespace HelloWorld
{
    public class Bird
    {
        string _word = "";

        public Bird(string word)
        {
            _word = word;
        }

        public virtual void Walk()
        {
            Console.WriteLine($"{nameof(Bird)} walks");
        }

        public void Speak()
        {
            Console.WriteLine(_word);
        }
    }
}