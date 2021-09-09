using System;

namespace ElectraAlgorithm
{
    public static class Matrix
    {
        public static void CreateMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, i] = "X";
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
