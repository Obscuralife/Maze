using System;

namespace Lab_Maze
{
    internal static class RenderEngine
    {
        #region CursorPosition
        private struct CursorPosition
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }
        private static CursorPosition CurrentConsoleCursorPosition;
        #endregion

        private static void Red() => Console.ForegroundColor = ConsoleColor.Red;
        private static void Yellow() => Console.ForegroundColor = ConsoleColor.Yellow;
        private static void Green() => Console.ForegroundColor = ConsoleColor.Green;
        private static void DarkCyan() => Console.ForegroundColor = ConsoleColor.DarkCyan;

        public static void RenderRules()
        {
            var stars = new string('*', 10);
            Red();
            Console.Write(stars);
            Yellow();
            Console.Write($"Please observe the Rules");
            Red();
            Console.WriteLine(stars);
            Green();
            Console.WriteLine($"   Rules:");
            Yellow();
            Console.WriteLine($"1: Press 'R' to generate a new random maze.");
            Console.WriteLine($"2: Use Arrows or 'W' 'S' 'A' 'D'.");
            Console.WriteLine($"3: For Exit press 'Esc'.");
            Console.WriteLine($"   Good Luck!\n");
            Console.ResetColor();
        }

        public static void RenderArea(Area area)
        {
            CurrentConsoleCursorPosition.Column = Console.CursorLeft;
            CurrentConsoleCursorPosition.Row = Console.CursorTop;
            DarkCyan();
            for (int i = 0; i < area.Heigth; i++)
            {
                for (int k = 0; k < area.Width; k++)
                {
                    if (i == 0 || i == area.Heigth - 1)
                    {
                        Console.Write('#');
                    }
                    else if (k == 0 || k == area.Width - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void RenderMaze(Maze maze)
        {
            Yellow();
            Console.CursorLeft = CurrentConsoleCursorPosition.Column + 1;
            Console.CursorTop = CurrentConsoleCursorPosition.Row + 1;
           
            for (int rows = 0; rows < maze.cells.GetLength(0); rows++)
            {
                for (int columns = 0; columns < maze.cells.GetLength(1); columns++)
                {
                    var current = maze.cells[rows, columns];
                    
                    switch (current?.Name)
                    {
                        case "Player":
                            {
                                Console.ForegroundColor = current.Color;
                                Console.Write(current.Symbol);
                                break;
                            }
                        case "Wall":
                            {
                                Console.ForegroundColor = current.Color;
                                Console.Write(current.Symbol);
                                break;
                            }
                        case "Road":
                            {
                                Console.ForegroundColor = current.Color;
                                Console.Write(current.Symbol);
                                break;
                            }
                        case "Coin":
                            {
                                Console.ForegroundColor = current.Color;
                                Console.Write(current.Symbol);
                                break;
                            }
                        default:
                            break;
                    }
                    Yellow();
                }
                Console.WriteLine();
                Console.CursorLeft += 1;
            }
            Maze.player.IsGenerated = false;
        }
    }
}