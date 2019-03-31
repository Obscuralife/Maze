using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze.Cells
{
    class Road : Cell
    {
        public Road()
        {
            Symbol = '.';
            Color = ConsoleColor.White;
            Name = "Road";
            IsVisited = true;
        }
    }
}
