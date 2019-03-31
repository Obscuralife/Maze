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

        public static void GenerateMaze(MazeField field, Player player)
        {
            GeneratePlayer();
            SetPlayerInMazeField(field, player);
            //GetNeighboursFirstTime(player);

        }

        private static void SetPlayerInMazeField(MazeField mazeField, Player player)
        {
            mazeField.cells[playerPosition.y, playerPosition.x] = player.PlayerCell;
        }

        //private static void GetNeighboursFirstTime(Player player)
        //{
        //    var neigboursCells = new List<Cell>();

        //    var Ydim = cells.GetLength(0) - 1;
        //    var Xdim = cells.GetLength(1) - 1;

        //    if (player.playerPosition.y - 1 < Ydim && player.playerPosition.y - 1 >= 0)
        //    {
        //        cells[playerPosition.Y, playerPosition.X] = new Cell()
        //        {
        //            Symbol = '_',
        //            Color = ConsoleColor.White,
        //            Name = "Road"
        //        };
        //        neigboursCells.Add();
        //    }
        //    if (playerPosition.Y + 1 <= Ydim)
        //    {
        //        roadCell.Y++;
        //        neigboursCells.Add(roadCell);
        //    }
        //    if (playerPosition.X - 1 < Xdim && playerPosition.X - 1 >= 0)
        //    {
        //        roadCell.X--;
        //        roadCell.Y = playerPosition.Y;
        //        neigboursCells.Add(roadCell);
        //    }
        //    if (playerPosition.X + 1 <= Xdim)
        //    {
        //        roadCell.X++;
        //        roadCell.Y = playerPosition.Y;
        //        neigboursCells.Add(roadCell);
        //    }
        //}
    }
}
