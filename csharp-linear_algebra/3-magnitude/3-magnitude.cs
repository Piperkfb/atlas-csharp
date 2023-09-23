using System;

/// <summary>
/// Class for math relating to vectors
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Find MAgnitune of 2D or #d vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns></returns>
    public static double Magnitude(double[] vector)
    {
        if(vector.Length == 3)
        {
            double bsq = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
            double res = Math.Round(Math.Sqrt(bsq), 2);
            return res;
        //|v| = √(x^2 + y^2 + z^2)
        //In this case, v = (7, -3, -9), so:
        //|v| = √(7^2 + (-3)^2 + (-9)^2)
        }
        else if(vector.Length == 2)
        {
            double bsq = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
            double res = Math.Round(Math.Sqrt(bsq), 2);
            return res;
        //|v| = √(x^2 + y^2)
        //In this case, v = (3, 9), so:
        //|v| = √(3^2 + 9^2)
        }
        else
        {
            return -1;
        }
    }
}