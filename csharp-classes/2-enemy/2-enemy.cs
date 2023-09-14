using System;

namespace Enemies
{
    ///<summary>
    /// This is a public class called Zombie.
    ///</summary>
    public class Zombie
    {
        ///<summary>
        /// This is a public int that gives a zombie health.
        ///</summary>

        public int health;

        ///<summary>
        /// this is a public constructor that specifies a health value.
        /// </summary>

        public Zombie()
        {
            health = 0;
        }

        ///<summary>
        /// This is a public constructor that specifies a positive health value.
        ///</summary>

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}