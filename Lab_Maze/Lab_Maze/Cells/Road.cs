﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze.Cells
{
    class Road : ICell
    {
        public char Symbol => '.';
        public ConsoleColor Color => ConsoleColor.White;
        public string Name => "Road";
        public int X { get; set; }
        public int Y { get; set; }
    }
}
