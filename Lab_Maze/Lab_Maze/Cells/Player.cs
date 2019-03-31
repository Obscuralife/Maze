using System;

namespace Lab_Maze
{
    public class Player : ICell
    {
        #region SingleTon
        private Player()
        { }


        public static Player GetPlayer()
        {
            if (@this is null)
            {
                @this = new Player();
                Generator.GeneratePlayerPosition(@this);
            }
            return @this;
        }
        #endregion

        private static Player @this;
        public char Symbol => '@';
        public ConsoleColor Color => ConsoleColor.Red;
        public string Name => "Player";
        public int X { get; set; }
        public int Y { get; set; }



    }
}