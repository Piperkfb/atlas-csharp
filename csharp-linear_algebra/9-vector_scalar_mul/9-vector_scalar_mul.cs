using System;

/// <summary>
/// Class vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies Vector bya  Scalar
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        // 2d or 3d
        double[] results = {0, 0}
        for (int i = 0; i <= 2; i++)
        {
            results[i] = (vector[i] * scalar);
            return results;
        }
        return new double[] {-1};
    }
}