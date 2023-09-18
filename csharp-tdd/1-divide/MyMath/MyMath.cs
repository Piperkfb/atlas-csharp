using System;

namespace MyMath
{
    /// <summary>
    /// Mathod to divide
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide those matrixes!
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if(num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return(null);
            }
            else if(matrix == null)
            {
                return(null);
            }
            else
            {
                for(int x = 0; x < matrix.GetLength(0); x++)
                {
                    for(int y = 0; y < matrix.GetLength(1); y++)
                    {
                        matrix[x, y] = matrix[x, y] / num;
                    }
                }
                return(matrix);
            }
        }
    }
}