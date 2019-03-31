using Lab_Maze.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_Maze
{
    internal static class Generator
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static ICell[,] cells;

        public static void GeneratePlayerPosition(Player player)
        {
            int x = 0;
            int y = 0;

            switch (new Random((int)DateTime.Now.Ticks).Next(0, 4))
            {
                case 0:
                    {
                        x = random.Next(0, Maze.Width);
                        y = 0;
                        break;
                    }
                case 1:
                    {
                        x = 0;
                        y = random.Next(0, Maze.Heigth);
                        break;
                    }
                case 2:
                    {
                        x = random.Next(0, Maze.Width);
                        y = Maze.Heigth - 1;
                        break;
                    }
                case 3:
                    {
                        x = Maze.Heigth - 1;
                        y = random.Next(0, Maze.Heigth);
                        break;
                    }
                default: throw new Exception("Generate Exception");
            }

            player.X = x;
            player.Y = y;
        }

        public static void GenerateMaze(Maze maze)
        {
            cells = maze.cells;
            SetNeighbours(new List<ICell> { Maze.player });
        }
        private static void SetNeighbours(List<ICell> cell)
        {
            var neighbours = new List<ICell>();
            foreach (var item in cell)
            {
                var cellX = item.X;
                var cellY = item.Y;

                var Ydim = cells.GetLength(0) - 1;
                var Xdim = cells.GetLength(1) - 1;

                ICell up;
                ICell down;
                ICell left;
                ICell right;

                if (cellY - 1 < Ydim && cellY - 1 >= 0)
                {
                    up = cells[cellY - 1, cellX];
                    if (up is null)
                    {
                        GetRandomCell(ref up, cellY - 1, cellX);
                        neighbours.Add(up);
                    }
                }
                if (cellY + 1 <= Ydim)
                {
                    down = cells[cellY + 1, cellX];
                    if (down is null)
                    {
                        GetRandomCell(ref down, cellY + 1, cellX);
                        neighbours.Add(down);
                    }
                }
                if (cellX - 1 < Xdim && cellX - 1 >= 0)
                {
                    left = cells[cellY, cellX - 1];
                    if (left is null)
                    {
                        GetRandomCell(ref left, cellY, cellX - 1);
                        neighbours.Add(left);
                    }
                }
                if (cellX + 1 <= Xdim)
                {
                    right = cells[cellY, cellX + 1];
                    if (right is null)
                    {
                        GetRandomCell(ref right, cellY, cellX + 1);
                        neighbours.Add(right);
                    }
                }
                SetNeighbours(neighbours);
            }
        }

        private static void GetRandomCell(ref ICell cell, int y, int x)
        {
            switch (random.Next(0, 8))
            {
                case 0:
                    {
                        cell = new Coin() { Y = y, X = x };
                        break;
                    }
                case 1:
                case 2:
                case 3:
                case 4:                
                    {
                        cell = new Road() { Y = y, X = x }; ;
                        break;
                    }
                case 5:
                case 6:
                case 7:
                    {
                        cell = new Wall() { Y = y, X = x }; ;
                        break;
                    }
                default:
                    break;
            }
            cells[y, x] = cell;
        }
    }
}
