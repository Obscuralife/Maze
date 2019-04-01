using Lab_Maze.Cells;
using System;

namespace Lab_Maze.Engines
{
    static class GameEngine
    {
        public static int? Score { get; private set; }
        public static bool WasNewPlayerGenerated { get; private set; } = true;

        public static void ButtonHandler(Maze maze)
        {
            var player = Player.GetPlayer();

            var coin = new Coin();
            var road = new Road();

            var Ydim = maze.cells.GetLength(0) - 1;
            var Xdim = maze.cells.GetLength(1) - 1;

            ConsoleKeyInfo consoleKey;
            while (true)
            {
                consoleKey = Console.ReadKey(true);
                switch (consoleKey.Key)
                {
                    case ConsoleKey.R:
                        {
                            if (!WasNewPlayerGenerated)
                            {
                                maze.cells = new ICell[Maze.Heigth, Maze.Width];
                                Generator.GeneratePlayerPosition(player);
                                maze.cells[player.Y, player.X] = player;
                                maze.GenerateAgain();
                                }
                            RenderEngine.RenderMaze(maze);
                            WasNewPlayerGenerated = false;
                            Score = 0;
                            break;
                        }
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        {
                            if ((player.Y - 1 <= Ydim && player.Y - 1 >= 0) &&
                                (maze.cells[player.Y - 1, player.X].Name != "Wall"))
                            {
                                if (maze.cells[player.Y - 1, player.X].Name == "Coin")
                                {
                                    Score++;
                                }
                                maze.cells[player.Y, player.X] = road;
                                player.Y--;
                                maze.cells[player.Y, player.X] = player;
                                RenderEngine.RenderMaze(maze);
                            }
                            else
                            {
                                Console.Beep(1000, 50);
                            }
                            break;
                        }
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        {
                            if ((player.Y + 1 <= Ydim) &&
                                (maze.cells[player.Y + 1, player.X].Name != "Wall"))
                            {
                                if (maze.cells[player.Y + 1, player.X].Name == "Coin")
                                {
                                    Score++;
                                }
                                maze.cells[player.Y, player.X] = road;
                                player.Y++;
                                maze.cells[player.Y, player.X] = player;
                                RenderEngine.RenderMaze(maze);
                            }
                            else
                            {
                                Console.Beep(1000, 50);
                            }
                            break;
                        }
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        {
                            if ((player.X - 1 >= 0) &&
                                (maze.cells[player.Y, player.X - 1].Name != "Wall"))
                            {
                                if (maze.cells[player.Y, player.X - 1].Name == "Coin")
                                {
                                    Score++;
                                }
                                maze.cells[player.Y, player.X] = road;
                                player.X--;
                                maze.cells[player.Y, player.X] = player;
                                RenderEngine.RenderMaze(maze);
                            }
                            else
                            {
                                Console.Beep(1000, 50);
                            }
                            break;
                        }
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        {
                            if ((player.X + 1 <= Xdim) &&
                                (maze.cells[player.Y, player.X + 1].Name != "Wall"))
                            {
                                if (maze.cells[player.Y, player.X + 1].Name == "Coin")
                                {
                                    Score++;
                                }
                                maze.cells[player.Y, player.X] = road;
                                player.X++;
                                maze.cells[player.Y, player.X] = player;
                                RenderEngine.RenderMaze(maze);
                            }
                            else
                            {
                                Console.Beep(1000, 50);
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }

        }
    }
}