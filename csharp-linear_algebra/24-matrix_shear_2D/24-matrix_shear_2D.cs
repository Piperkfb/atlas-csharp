using System;

/// <summary>
/// class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// shear 2d matrix
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] res = new double[2,2];
        double[,] shearMatrix;
        double[,] fail;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            if (direction == 'x')
                shearMatrix = new double[,] {{1, 0}, {factor, 1}};
            else if (direction == 'y')
                shearMatrix = new double[,] {{1, factor}, {0, 1}};
        
            for (int i = 0; i < 2; i++)
			    for (int j = 0; j < 2; j++)
				    for (int k = 0; k < 2; k++)
					    res[i, j] += (matrix[i, k] * shearMatrix[k, j]);
            return res;           
        }
		return fail;
    }
}