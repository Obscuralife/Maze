using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze.Cells
{
    class Wall : Cell
    {
        public Wall()
        {
            IsVisited = true;
        }
    }
}
