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
            new Maze(10, 10).Play();
            Console.ReadLine();
        }
    }
}
