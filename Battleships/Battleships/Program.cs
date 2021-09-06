using System;
using Battleships.Models;

namespace Battleships
{
    class Program
    {
        static Player Player1 { get; set; }
        static Player Computer { get; set; }

        static void Main(string[] args)
        {
            bool gameEnded = false;

            Setup();

            //Game loop begins 
            while (!gameEnded)
            {
                gameEnded = true;
            }


        }

        static void Setup()
        {
            //Create players
            Player1 = new Player();
            Computer = new Player();

            //Create ships
            //Player 1 places 5 ships
            //Computer places 5 ships 
            //Decide who goes first

        }
    }
}
