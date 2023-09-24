using System;

/// <summary>
/// MAth for Matrixes
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotate 2d matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
        {
            // If the matrix is not square, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the rotated values
        double[,] rotatedMatrix = new double[rows, cols];

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Apply rotation formula to each element
                double x = matrix[i, j];
                double newX = x * cosTheta - x * sinTheta;

                rotatedMatrix[i, j] = newX;
            }
        }

        return rotatedMatrix;
    }
}