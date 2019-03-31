using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze
{
    class Cell
    {
        public char Symbol { get; set; } = '#';
        public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
        public string Name { get; set; } = "Wall";
        public bool IsVisited { get; set; } = false;
    }
}
