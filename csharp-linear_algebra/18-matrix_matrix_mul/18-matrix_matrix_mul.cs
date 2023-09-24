using System;

/// <summary>
/// Math for Matrixes
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// multiply matrixes
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
		int row1 = matrix1.GetLength(0);
		int col1 = matrix1.GetLength(1);
		int row2 = matrix2.GetLength(0);
		int col2 = matrix2.GetLength(1);
        double[,] matrix3 = new double[row1, col2];
        double[,] MT = {{-1}};

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return MT;
        else
		{
			for (int i = 0; i < row1; i++)
				for (int j = 0; j < col2; j++)
					for (int k = 0; k < col1; k++)
						matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
			return matrix3;
        }
    }
}