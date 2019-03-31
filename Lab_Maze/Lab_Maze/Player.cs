using System;

namespace Lab_Maze
{
    internal class Player
    {
        public struct PlayerPosition
        {
            public int x;
            public int y;
        }
        public Cell PlayerCell { get; private set; }
        public  PlayerPosition playerPosition { get; set; }
        private static Player @this;
        #region SingleTon
        private Player()
        {
            PlayerCell = new Cell()
            {
                Symbol = '@',
                Color = ConsoleColor.DarkRed,
                Name = "Player",
                IsVisited = true
            };
        }
        public static Player GetPlayer()
        {
            if (@this is null)
            {
                @this = new Player();
            }
            return @this;
        }
        #endregion



    }
}