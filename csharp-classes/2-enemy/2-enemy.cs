using System;

namespace Enemies
{
    class Zombie
    {
        public int health;
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArguementException("Health must be greater than or equal to 0")
            }
        }
    }
}