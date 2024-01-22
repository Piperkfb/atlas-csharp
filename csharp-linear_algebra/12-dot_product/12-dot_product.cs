using System;

/// <summary>
/// Class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculate dot product of two vectors
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            int results = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
            return results;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            int result = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
            return results;
        }
        return (-1);
    }   
}