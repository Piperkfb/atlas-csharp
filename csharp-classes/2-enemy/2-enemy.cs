using System;

namespace Enemies
{
    class Zombies
    {
        public int health;
        public Zombies()
        {
            health = 0;
        }
        public Zombies(int value)
        {
            if (value < 0)
            {
                throw new ArguementException("Health must be greater than or equal to 0")
            }
        }
    }
}