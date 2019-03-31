using Lab_Maze.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Maze
{
    internal static class Generator
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static Cell[,] cells = MazeField.GetMazeField().cells;
        private static Player.PlayerPosition playerPosition;

        private static void GeneratePlayer()
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

            playerPosition.x = x;
            playerPosition.y = y;
        }

        public static void GenerateMaze(MazeField field)
        {
            GeneratePlayer();
            SetPlayerInMazeField(field);
            SetNeighboursForPlayerFT();
        }

        private static void SetPlayerInMazeField(MazeField mazeField)
        {
            mazeField.cells[playerPosition.y, playerPosition.x] = (Cell)Player.GetPlayer();
        }

        private static void SetNeighboursForPlayerFT()
        {
            var road = new Road();
            var neighbours = new List<Cell>();
            var pX = playerPosition.x;
            var pY = playerPosition.y;

            var Ydim = cells.GetLength(0) - 1;
            var Xdim = cells.GetLength(1) - 1;

            if (pY - 1 < Ydim && pY - 1 >= 0)
            {
                cells[pY - 1, pX] = road;
                neighbours.Add(cells[pY - 1, pX]);
            }
            if (pY + 1 <= Ydim)
            {
                cells[pY + 1, pX] = road;
                neighbours.Add(cells[pY + 1, pX]);
            }
            if (pX - 1 < Xdim && pX - 1 >= 0)
            {
                cells[pY, pX - 1] = road;
                neighbours.Add(cells[pY, pX - 1]);
            }
            if (pX + 1 <= Xdim)
            {
                cells[pY, pX + 1] = road;
                neighbours.Add(cells[pY, pX + 1]);
            }

            GenerateCells(neighbours);
        }

        private static void GenerateCells(List<Cell> neighbours)
        {
            
        }
    }
}
