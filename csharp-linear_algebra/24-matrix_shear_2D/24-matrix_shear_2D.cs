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
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];

        if (direction == 'x')
        {
            result[0, 0] = matrix[0, 0] + factor * matrix[1, 0];
            result[1, 0] = matrix[1, 0];
            result[0, 1] = matrix[0, 1] + factor * matrix[1, 1];
            result[1, 1] = matrix[1, 1];
        }
        else
        {
            result[0, 0] = matrix[0, 0];
            result[1, 0] = matrix[1, 0] + factor * matrix[0, 0];
            result[0, 1] = matrix[0, 1];
            result[1, 1] = matrix[1, 1] + factor * matrix[0, 1];
        }

        return result;
    }
}
