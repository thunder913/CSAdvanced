using System;
using System.Linq;
namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize, matrixSize];
            for (int row = 0; row < matrixSize; row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var bombLocaitons = Console.ReadLine().Split();
            var rows = new int[bombLocaitons.Length];
            var cols = new int[bombLocaitons.Length];
            for (int i = 0; i < bombLocaitons.Length; i++)
            {
                rows[i] = bombLocaitons[i][0] - 48;
                cols[i] = bombLocaitons[i][2] - 48;
            }

            for (int i = 0; i < rows.Length; i++)
            {
                int currentRow = rows[i];
                int currentCol = cols[i];
                int bombPower = matrix[currentRow, currentCol];
                if (matrix[currentRow, currentCol] > 0)
                {
                    if (currentRow + 1 < matrixSize && matrix[currentRow + 1, currentCol] > 0)
                    {
                        matrix[currentRow + 1, currentCol] -= bombPower;
                    }
                    if (currentRow + 1 < matrixSize && currentCol + 1 < matrixSize && matrix[currentRow + 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol + 1] -= bombPower;
                    }
                    if (currentRow + 1 < matrixSize && currentCol - 1 >= 0 && matrix[currentRow + 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol - 1] -= bombPower;
                    }
                    if (currentRow - 1 >= 0 && currentCol - 1 >= 0 && matrix[currentRow - 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol - 1] -= bombPower;
                    }
                    if (currentRow - 1 >= 0 && currentCol + 1 < matrixSize && matrix[currentRow - 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol + 1] -= bombPower;
                    }
                    if (currentCol - 1 >= 0 && matrix[currentRow, currentCol - 1] > 0)
                    {
                        matrix[currentRow, currentCol - 1] -= bombPower;
                    }
                    if (currentRow - 1 >= 0 && matrix[currentRow - 1, currentCol] > 0)
                    {
                        matrix[currentRow - 1, currentCol] -= bombPower;
                    }
                    if (currentCol + 1 < matrixSize && matrix[currentRow, currentCol + 1] > 0)
                    {
                        matrix[currentRow, currentCol + 1] -= bombPower;
                    }
                    matrix[currentRow, currentCol] = 0;
                }
            }
            int aliveCellsCount = 0;
            int sum = 0;
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row,col] > 0)
                    {
                        aliveCellsCount++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
