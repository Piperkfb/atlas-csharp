using System;

/// <summary>
/// Math for Matrix
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a mtrix
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows];

        for (int x = 0; x < rows; x++)
            for (int y = 0; y < cols; y++)
                restult[y, x] = matrix[x, y];
        return result;
    }
}