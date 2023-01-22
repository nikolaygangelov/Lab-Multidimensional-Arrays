using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
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
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputOfMatrix[col];
                }
            }

            //int sum = 0;
            int maxSumOfSubMatrix = 0;
            int indexOfRows = 0;
            int indexOfCols = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)//първи ред
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)//от първа до последна колона
                {
                    int sumOfSubMatrix = 0;
                    for (int subRow = 0; subRow < 2; subRow++)//първи ред
                    {
                        for (int subCol = 0; subCol < 2; subCol++)//от първа до последна колона
                        {
                            //7, 1, 3, 3, 2, 1
                            //1, 3, 9, 8, 5, 6
                            //4, 6, 7, 9, 1, 0
                            sumOfSubMatrix += matrix[row + subRow, col + subCol];
                        }
                    }
                    if (sumOfSubMatrix > maxSumOfSubMatrix)
                    {
                        maxSumOfSubMatrix = sumOfSubMatrix;
                        indexOfRows = row;
                        indexOfCols = col;
                    }
                    //else if (sumOfSubMatrix == maxSumOfSubMatrix)
                    //{
                    //    if (row < indexOfRows)
                    //    {
                    //        indexOfRows = row;
                    //    }
                    //}
                }
            }

            for (int row = indexOfRows; row < indexOfRows + 2; row++)
            {
                for (int col = indexOfCols; col < indexOfCols + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSumOfSubMatrix);
        }
    }
}
