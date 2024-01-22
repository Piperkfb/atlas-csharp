using System;

namespace _3_magnitude
{
    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                double cSquared = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
                return Math.Sqrt(cSquared);
            }
            //determine if 2d or 3d
            else if (vector.Length == 3)
            {
                double cSquared = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
                return Math.Sqrt(cSquared);
            }
            //if neither, return -1
            else
            {
                return (-1);
            }
        }
    }
}
