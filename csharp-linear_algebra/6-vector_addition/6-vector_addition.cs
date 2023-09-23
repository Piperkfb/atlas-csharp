using System;

/// <summary>
/// class for meth of vectors
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Add two vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] res = {vector1[0] + vector2[0], vector1[1] + vector2[1]};
        return res;
    }
}