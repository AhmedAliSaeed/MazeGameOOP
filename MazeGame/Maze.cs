using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        private int _Width;
        private int _Height;
        private Player _Player;
        private IMazeObject[,] _MazeObjectArray;

        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            _MazeObjectArray = new IMazeObject[width, height];
            _Player = new Player()
            {
                X = 1,
                Y = 1,
            };
        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Height; y++)
            {
                for (int x = 0; x < _Width; x++)
                {

                  if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);

                    }
                    else if (x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    //الوصول للنهاية
                    else if (x == _Width - 2 && y == _Height - 2)
                    {
                        _MazeObjectArray[x, y] = new Exit();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }


                }
                Console.WriteLine();
            }
        }

        //public void DrawMaze()
        //{
        //    Console.Clear();

        //    for (int y = 0; y < _Height; y++)
        //    {
        //        for (int x = 0; x < _Width; x++)
        //        {
        //            // الحدود الخارجية
        //            if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
        //            {
        //                _MazeObjectArray[x, y] = new Wall();
        //                Console.Write(_MazeObjectArray[x, y].Icon);
        //            }
        //            // مكان اللاعب
        //            else if (x == _Player.X && y == _Player.Y)
        //            {
        //                Console.Write(_Player.Icon);
        //            }
        //            // الأعمدة المقفولة جزئياً
        //            else if (x % 4 == 1)
        //            {
        //                // عمود رقم زوجي (فتحة تحت)
        //                if (y == _Height - 2)
        //                {
        //                    _MazeObjectArray[x, y] = new EmptySpace();
        //                    Console.Write(_MazeObjectArray[x, y].Icon);
        //                }
        //                else
        //                {
        //                    _MazeObjectArray[x, y] = new Wall();
        //                    Console.Write(_MazeObjectArray[x, y].Icon);
        //                }
        //            }
        //            else if (x % 4 == 3)
        //            {
        //                // عمود رقم فردي (فتحة فوق)
        //                if (y == 1)
        //                {
        //                    _MazeObjectArray[x, y] = new EmptySpace();
        //                    Console.Write(_MazeObjectArray[x, y].Icon);
        //                }
        //                else
        //                {
        //                    _MazeObjectArray[x, y] = new Wall();
        //                    Console.Write(_MazeObjectArray[x, y].Icon);
        //                }
        //            }


        //            // الأعمدة الفاضية اللي بين كل عمودين مقفولين
        //            else
        //            {
        //                _MazeObjectArray[x, y] = new EmptySpace();
        //                Console.Write(_MazeObjectArray[x, y].Icon);
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            ConsoleKey key = userInput.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow: UpdatePlayerPlace(0, -1);
                    break;
                case ConsoleKey.DownArrow: UpdatePlayerPlace(0, 1);
                    break;
                case ConsoleKey.LeftArrow: UpdatePlayerPlace(-1, 0);
                    break;
                case ConsoleKey.RightArrow: UpdatePlayerPlace(1, 0);
                    break;
            }

        }

        public void UpdatePlayerPlace(int dx, int dy)
        {
            int newX = _Player.X + dx;
            int newY = _Player.Y + dy;

            if (newX < _Width && newY < _Height && newX > 0 && newY> 0 && _MazeObjectArray[newX, newY].IsSolid == false)
            {              
                _Player.X = newX;
                _Player.Y = newY;

                if (_MazeObjectArray[newX, newY] is Exit)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You've reached the exit!");
                    Thread.Sleep(2000);
                    _Player.X = 1;
                    _Player.Y = 1;
                }


                DrawMaze();
            }

        }


    }
}
