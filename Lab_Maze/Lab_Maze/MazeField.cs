using System.Collections.Generic;

namespace Lab_Maze
{
    internal  class MazeField 
    {
        public Cell[,] cells;
        public static int Heigth { get; private set; }
        public static int Width { get; private set; }
        private static MazeField @this;

        
        #region SingleTon
        private MazeField(int heigth, int width)
        {
            cells = new Cell[heigth, width];
            Heigth = heigth + 2;
            Width = width + 2;
        }
        public static MazeField GetMazeField(int heigth = 0, int width = 0)
        {
            if (@this is null)
            {
                @this = new MazeField(heigth, width);
            }
            return @this;
        }
        #endregion

        
    }
}