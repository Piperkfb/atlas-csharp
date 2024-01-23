using System;

/// <summary>
/// Class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// multiplies a matrix by a scalar
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        //2d or 3d
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] res = {{0, 0}, {0, 0}};
            for (int i = 0; i <= 1; i++)
                for (int y = 0; y <= 1; y++)
                {
                    res[i, y] = (matrix1[i, y] * scalar);
                }
            return res;
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3 && matrix.GetLength(2) == 3)
        {
            double[,] res = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
            for (int i = 0; i <= 2; i++)
                for (int y = 0; y <= 2; y++)
                {
                    res[i, y] = (matrix[i, y] * scalar);
                }
            return res;
        }
        return new double[,] {{-1}};
    }
}