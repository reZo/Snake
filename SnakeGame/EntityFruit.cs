using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class EntityFruit : Entity
    {
        private int[] axis;

        public new int Index
        {
            get
            {
                return Snake.Default.INDEX_FRUIT;
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
    }
}
