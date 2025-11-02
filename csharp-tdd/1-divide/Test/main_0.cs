using System;
using MyMath;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
        int num = 2;
        
        int[,] result = Matrix.Divide(matrix, num);
        
        if (result != null)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j]);
                    if (j < result.GetLength(1) - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}