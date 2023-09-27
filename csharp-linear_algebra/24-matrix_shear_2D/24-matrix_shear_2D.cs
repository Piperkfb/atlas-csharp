using System;

public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] NewMatrix = new double[2,2];
        double[,] Fail = {{-1}};
        double[,] ShearMat;

        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return Fail;
        
        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
                ShearMat = new double[,] {{1, 0}, {factor, 1}};
            else
                ShearMat = new double[,] {{1, factor}, {0,1}};
        }
        else
            return Fail;
        for (int i = 0; i < 2; i++)
		    for (int j = 0; j < 2; j++)
			    for (int k = 0; k < 2; k++)
					NewMatrix[i, j] += (matrix[i, k] * ShearMat[k, j]);
        return NewMatrix;
    }
}