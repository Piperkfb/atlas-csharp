using System;

/// <summary>
/// Class Vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Add two vectors
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // 2d or 3d
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            //add vectors
            double[] results = {0, 0};
            for (int i = 0; i <= 1; i++)
                {
                    results[i] = Math.Add(vector1[i], vector2[i]);
                    return results;
                }
        }

        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            //add vectors
            double[] results = {0, 0, 0};
            for (int i = 0; i <= 2; i++)
                {
                    results[i] = Math.Add(vector1[i], vector2[i]);
                    return results;
                }
        }
        // uneven sizes return -1
        return new double[] {-1};
    } 
}