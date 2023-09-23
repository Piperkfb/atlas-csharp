using System;

/// <summary>
/// Math for vectorsssss
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculate dot producgt of vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double res = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
            return res;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double res = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
            return res;
        }
        else
            return (-1);
    }
}