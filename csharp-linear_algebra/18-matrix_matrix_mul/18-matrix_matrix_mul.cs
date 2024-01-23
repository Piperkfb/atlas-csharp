using System;

/// <summary>
/// class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// mutplies two matrixes
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int row1 = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);
        //m1 col(1) = m2 row(0) 
        if (col1 == row2)
        {
            //res matrix = m1 row by m2 col
            double[,] res = new double[row1, col2];
            for (int x = 0; x < row1; x++)
                for (int y = 0; y < col2; y++)
                    for (int i = 0; i < col1; i++)
                        {
                            res[x, y] += matrix1[x, i] * matrix2[i, y];
                        }
            return res;
        }
        return new double[,] {{-1}};
    }
}