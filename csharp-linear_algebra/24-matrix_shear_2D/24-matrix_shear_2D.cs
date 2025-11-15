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

        double[,] shearMatrix;
        if (direction == 'x')
        {
            shearMatrix = new double[,] { { 1, factor }, { 0, 1 } };
        }
        else
        {
            shearMatrix = new double[,] { { 1, 0 }, { factor, 1 } };
        }

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = shearMatrix[i, 0] * matrix[0, j] + shearMatrix[i, 1] * matrix[1, j];
            }
        }

        return result;
    }
}
