using System;

/// <summary>
/// class Matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        //2d or 3d
        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && 
        matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] res = {{0, 0}, {0, 0}};
            for (int i = 0; i <= 1; i++)
                for (int y = 0; y <= 1; y++)
                {
                    res[i, y] = (matrix1[i, y] + matrix2[i, y]);
                }
            return res;
        }
        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix1.GetLength(2) == 3 &&
        matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3 && matrix2.GetLength(2) == 3)
        {
            double[,] res = {{0, 0, 0}, {0, 0, 0}, {0, 0. 0}};
            for (int i = 0; i <= 2; i++)
                for (int y = 0; y <= 2; y++)
                {
                    res[i, y] = (matrix1[i, y] + matrix2[i, y]);
                }
            return res;
        }
        return new double[,] {{-1}};
    }
}