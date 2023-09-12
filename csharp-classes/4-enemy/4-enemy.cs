using System;

namespace Enemies
{
    class Zombie
    {
        int health;
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
        string name = (No name)
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int GetHealth()
        {
            return health;
        }
    }
}