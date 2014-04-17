using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Timer
    {
        int ticks;
        int lastTick;
        bool updateTicks = false;

        public Timer()
        {
            Reset();
        }

        public void Reset()
        {
            ticks = Environment.TickCount;
            lastTick = ticks;
        }

        public bool Next(int interval)
        {
            if (ticks > lastTick + interval)
            {
                return true;
            }

            return false;
        }

        public void Update()
        {
            if (updateTicks == false)
            {
                ticks = Environment.TickCount;
                updateTicks = true;
            }

            else if (updateTicks == true)
            {
                lastTick = ticks;
                updateTicks = false;
            }
        }

        public void Print()
        {
            Console.WriteLine("nope... ticks " + ticks + " lastTick " + lastTick);
        }
    }
}
