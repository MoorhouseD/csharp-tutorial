using System;

namespace Battleships
{
    class Program
    {
        const int GRID_SIZE = 8;
        public static int[,] Grid { get; set; }

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
            //Create grid
            Grid = new int[GRID_SIZE, GRID_SIZE];

            //Create ships
            //Player 1 places 5 ships
            //Computer places 5 ships 
            //Decide who goes first

        }
    }
}
