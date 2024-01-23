using System;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// find crossproduct of two vectors
    /// </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] res = new double[3];
        if (vector1.Length == 3 && vector2.Length == 3)
        {
        res[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        res[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        res[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return res;
        }
        return new double[] {-1};
    }
}