using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze.Cells
{
    class Coin : ICell
    {
        public char Symbol => '$';
        public ConsoleColor Color => ConsoleColor.Magenta;
        public string Name => "Coin";
        public int X { get; set; }
        public int Y { get; set; }
    }
}
