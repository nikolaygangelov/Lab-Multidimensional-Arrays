using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] inputOfMatrix = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputOfMatrix[col];
                }
            }

            int sum = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
