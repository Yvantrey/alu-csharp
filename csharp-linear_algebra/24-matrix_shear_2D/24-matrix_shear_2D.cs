using System;

public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor in either X or Y direction.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to shear.</param>
    /// <param name="direction">'x' for X direction, 'y' for Y direction.</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>
    /// The resulting sheared matrix.
    /// If the matrix is not square or the direction is invalid, returns a matrix containing -1.
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
            return new double[,] { { -1 } };

        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        double[,] shearMatrix = new double[rows, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if (i == j)
                    shearMatrix[i, j] = 1;
                else if (direction == 'x' && i == 0 && j == 1)
                    shearMatrix[i, j] = factor;
                else if (direction == 'y' && i == 1 && j == 0)
                    shearMatrix[i, j] = factor;
                else
                    shearMatrix[i, j] = 0;
            }
        }

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < rows; k++)
                {
                    result[i, j] += shearMatrix[i, k] * matrix[k, j];
                }
            }
        }

        return result;
    }
}
