using System.Collections.Generic;

namespace Lab_Maze
{
    internal class Area
    {
        public int Heigth { get; private set; }
        public int Width { get; private set; }
        private static Area @this;

        #region SingleTon
        private Area(int heigth, int width)
        {

            Heigth = heigth + 2;
            Width = width + 2;
        }
        public static Area GetMazeArea(int heigth = 0, int width = 0)
        {
            if (@this is null)
            {
                @this = new Area(heigth, width);
            }
            return @this;
        }
        #endregion


    }
}