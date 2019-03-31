using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze
{
    interface ICell
    {
        int X { get;  set; }
        int Y { get;  set; }
        char Symbol { get; }
        ConsoleColor Color { get; }
        string Name { get; }
    }
}
