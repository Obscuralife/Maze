using System;

namespace Lab_Maze
{
    internal class Player : Cell
    {
        public struct PlayerPosition
        {
            public int x;
            public int y;
        }
        public  static PlayerPosition playerPosition { get; set; }
        private static Player @this;
        #region SingleTon
        private Player()
        {
            Symbol = '@';
            Color = ConsoleColor.DarkRed;
            Name = "Player";
            IsVisited = true;
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