using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            var maze = new Maze(6, 6);
            maze.Play();
            Console.ReadLine();
        }
    }
}
