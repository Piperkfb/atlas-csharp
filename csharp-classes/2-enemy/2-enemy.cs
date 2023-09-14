﻿using System;

namespace Enemies
{
    /// <summary> public class Zombie </summary>
    public class Zombie
    {
        /// <summary>
        /// Is da health
        /// </summary>
        public int health;
          /// <summary> public constructor: public Zombie() Initializes in 0 </summary>
        public Zombie()
        {
            health = 0;
        }
         /// <summary> public constructor with parameter: public Zombie(value) Initializes in 0 </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}