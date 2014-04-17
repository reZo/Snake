using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    abstract class Entity
    {
        private int index;

        private int[] axis;

        private string display;

        // Identification index (IE, Blank space = 0, snake = 1, snake body = 2, fruit = 3)
        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        // X and Y axis of character
        public int[] Axis
        {
            get
            {
                return axis;
            }

            set
            {
                axis = value;
            }
        }

        // Character to display
        public string Display;
    }
}
