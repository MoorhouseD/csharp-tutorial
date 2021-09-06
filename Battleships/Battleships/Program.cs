using System;

namespace Battleships
{
    class Program
    {
        static int[,] Grid;
        static void Main(string[] args)
        {
            bool gameEnded = false;

            Setup();

            //Game loop beggins 
            while (!gameEnded)
            {
                gameEnded = true;
            }


        }

        static void Setup()
        {
            //Create grid
            Grid = new int[8, 8];

            //Create ships
            //Player 1 places 5 ships
            //Computer places 5 ships 
            //Decide who goes first

        }
    }
}
