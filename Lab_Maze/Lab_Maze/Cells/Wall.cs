using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze.Cells
{
    class Wall : ICell
    {
        public char Symbol => '#';
        public ConsoleColor Color => ConsoleColor.Yellow;
        public string Name => "Wall";
        public int X { get; set; }
        public int Y { get; set; }
    }
}
