using System;

/// <summary>
/// class to run math of vectores
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiply vectors and scalars
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns></returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] res = {vector[0] * scalar, vector[1] * scalar};
            return res;
        }
        else if (vector.Length == 3)
        {
            double[] res = {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
            return res;
        }
        else
            return new double[] {-1};
    }
}