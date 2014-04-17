using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

/**
 * NOTE:
 * Perhaps try making grid array size of Snake.Default.AREA and Snake.Default.AREA - easier to handle
 */

namespace SnakeGame
{
    class Grid
    {
        EntitySnake snake = new EntitySnake();
        EntityFruit fruit = new EntityFruit();

        private int[][] grid;

        public Grid()
        {
            // height width
            grid = new int[Snake.Default.AREA][];

            // create x & y axis coords for snake starting point, and fruit
            // TODO enable multiple fruit to be displayed
            // repeat random number generation till we find a free square
            snake.Axis = generateRandom();

            do
            {
                fruit.Axis = generateRandom();
            }

            while (snake.Axis[0] == fruit.Axis[0] && snake.Axis[1] == fruit.Axis[1]);

            // initalize the grid array

            int i;

            for (i = 0; i < Snake.Default.AREA; i++)
            {
                grid[i] = new int[Snake.Default.AREA];
            }

            Generate();
        }

        public void Generate()
        {
            for (int i = 0; i < Snake.Default.AREA; i++)
            {
                for (int j = 0; j < Snake.Default.AREA; j++)
                {
                    if (snake.Axis[0] == i && snake.Axis[1] == j)
                    {
                        grid[i][j] = Snake.Default.INDEX_SNAKE;
                    }

                    else if (fruit.Axis[0] == i && fruit.Axis[1] == j)
                    {
                        grid[i][j] = Snake.Default.INDEX_FRUIT;
                    }

                    else
                    {
                        grid[i][j] = Snake.Default.INDEX_WHITESPACE;
                    }
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Updated grid.");
        }

        public void Display()
        {
            for (int i = 0; i < Snake.Default.AREA; i++)
            {
                for (int j = 0; j < Snake.Default.AREA; j++)
                {
                    if (grid[i][j] == Snake.Default.INDEX_SNAKE)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("#");
                    }

                    if (grid[i][j] == Snake.Default.INDEX_FRUIT)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("O");
                    }
                }
            }
        }

        /**
         * Generate a random position
         */

        public int[] generateRandom()
        {
            Random random = new Random();
            int[] number;

            number = new int[] { random.Next(0, Snake.Default.AREA), random.Next(0, Snake.Default.AREA) };

            return number;
        }

        public void snakeMove(string direction)
        {
            if (direction == "up")
            {
                snake.Axis[1]--;
            }

            else if (direction == "down")
            {
                snake.Axis[1]++;
            }

            else if (direction == "left")
            {
                snake.Axis[0]--;
            }

            else if (direction == "right")
            {
                snake.Axis[0]++;
            }
        }
    }
}