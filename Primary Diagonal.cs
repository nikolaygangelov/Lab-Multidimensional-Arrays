using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            int sum = 0;
            for (int row = 0; row < N; row++)
            {
                int[] inputOfMatrix = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = inputOfMatrix[col];
                }
                    sum += matrix[row, row];
            }
            Console.WriteLine(sum);
        }
    }
}
