using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze
{
    internal class Maze
    {
        public static int Heigth { get; private set; }
        public static int Width { get; private set; }

        private static Player player;
        private static MazeField mazeField;

        public Maze(int heigth, int width)
        {
            Heigth = heigth;
            Width = width;
            player = Player.GetPlayer();
            mazeField = MazeField.GetMazeField(heigth, width);            
        }

        public void Play()
        {
            RenderEngine.RenderRules();
            RenderEngine.RenderArea();
            RenderEngine.RenderMaze(mazeField);
        }


    }
}
