using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static bool gameRun = true;
        static Grid gameGrid = new Grid();

        static void Main(string[] args)
        {
            while (gameRun)
            {
                Thread.Sleep(50);
                /*// check up on this usage of Console.ReadKey()
                keyboard = Console.ReadKey(true);
                Thread.Sleep(50);
                //if (timer.Next(10) == true)
                //{
                    //timer.Update();

                    if (keyboard.Key == ConsoleKey.UpArrow)
                    {
                        Console.WriteLine("Up");
                    }

                    else if (keyboard.Key == ConsoleKey.DownArrow)
                    {
                        Console.WriteLine("Down");
                    }

                    else if (keyboard.Key == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("Left");
                    }

                    else if (keyboard.Key == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("Right");
                    }

                    else if (keyboard.Key == ConsoleKey.Escape)
                    {
                        gameRun = false;
                    }
                //}

                //timer.Update();*/
                KeyboardHandler();
                gameGrid.Generate();
                gameGrid.Display();
            }
        }

        static public void KeyboardHandler()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyboard = Console.ReadKey(true);

                if (keyboard.Key == ConsoleKey.Escape)
                {
                    gameRun = false;
                }

                else if (keyboard.Key == ConsoleKey.UpArrow)
                {
                    gameGrid.snakeMove("up");
                }

                else if (keyboard.Key == ConsoleKey.DownArrow)
                {
                    gameGrid.snakeMove("down");
                }

                else if (keyboard.Key == ConsoleKey.LeftArrow)
                {
                    gameGrid.snakeMove("left");
                }

                else if (keyboard.Key == ConsoleKey.RightArrow)
                {
                    gameGrid.snakeMove("right");
                }
            }
        }
    }
}
