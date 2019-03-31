using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze
{
    internal class Maze
    {
        public ICell[,] cells;
        public static int Heigth { get; private set; }
        public static int Width { get; private set; }
        
        public static Player player { get; private set; }
        private static Area area;

        public Maze(int heigth = 5, int width = 5)
        {
            cells = new ICell[heigth, width];
            Heigth = heigth;
            Width = width;
            area = Area.GetMazeField(heigth, width);            
            player = Player.GetPlayer();
            cells[player.Y, player.X] = player as ICell;
        }

        public void Play()
        {
            RenderEngine.RenderRules();
            RenderEngine.RenderArea(area);
            RenderEngine.RenderMaze(this);
        }


    }
}
