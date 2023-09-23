using System;

/// <summary>
/// Math for MAtrixes
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Add matrixes
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
		if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 &&
		matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] res = {
                {0, 0},
                {0, 0}
            };
            res[0, 0] = matrix1[0, 0] + matrix2[0, 0];
            res[0, 1] = matrix1[0, 1] + matrix2[0, 1];
            res[1, 0] = matrix1[1, 0] + matrix2[1, 0];   
            res[1, 1] = matrix1[1, 1] + matrix2[1, 1];
            return res;
        }
        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 &&
		matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
			double[,] matrix3 = {
				{0, 0, 0},
				{0, 0, 0},
				{0, 0, 0}
			};
			matrix3[0, 0] = matrix1[0, 0] + matrix2[0, 0];
			matrix3[0, 1] = matrix1[0, 1] + matrix2[0, 1];
			matrix3[0, 2] = matrix1[0, 2] + matrix2[0, 2];
			matrix3[1, 0] = matrix1[1, 0] + matrix2[1, 0];
			matrix3[1, 1] = matrix1[1, 1] + matrix2[1, 1];
			matrix3[1, 2] = matrix1[1, 2] + matrix2[1, 2];
			matrix3[2, 0] = matrix1[2, 0] + matrix2[2, 0];
			matrix3[2, 1] = matrix1[2, 1] + matrix2[2, 1];
			matrix3[2, 2] = matrix1[2, 2] + matrix2[2, 2];
			return matrix3;
        }
        else
            return new double[,]{{-1}};
    }
}