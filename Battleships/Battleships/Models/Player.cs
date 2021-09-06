using Battleships.Enums;

namespace Battleships.Models
{
    public class Player
    {
        //Name

        // Player's Grid
        public TileType[,] PlayerGrid { get; }

        //Enemy Grid
        public TileType[,] FiringGrid { get; }

        // Ships

        // Has Lost?

        public Player()
        {
            PlayerGrid = new TileType[8, 8];
            FiringGrid = new TileType[8, 8];
        }


    }
}
