using System;

namespace Enemies
{
    class Zombies
    {
        int health;
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