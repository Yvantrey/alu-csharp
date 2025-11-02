using System;

namespace MyMath
{
    /// <summary>
    /// Provides matrix operations
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix by a given number
        /// </summary>
        /// <param name="matrix">The matrix to divide</param>
        /// <param name="num">The number to divide by</param>
        /// <returns>A new matrix with divided elements, or null if matrix is null or num is 0</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            // Check if matrix is null
            if (matrix == null)
                return null;

            // Check if num is 0
            try
            {
                if (num == 0)
                    throw new DivideByZeroException();

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] result = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }

                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}