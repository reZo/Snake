using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class EntitySnake : Entity
    {
        private int[] axis;

        public new int Index
        {
            get
            {
                return Snake.Default.INDEX_SNAKE;
            }
        }

        public new int[] Axis
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

        public new string Display
        {
            get
            {
                return Snake.Default.DISPLAY_SNAKE;
            }
        }
    }
}
