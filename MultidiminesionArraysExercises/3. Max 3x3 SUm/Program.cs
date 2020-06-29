using System;
using System.Linq;
namespace _3._Max_3x3_SUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRow = 0, maxCol = 0;
            int maxSum = int.MinValue;
            var dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalRows = dimension[0];
            int totalColumns = dimension[1];
            var matrix = new int[totalRows, totalColumns];
            for (int row = 0; row < totalRows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < totalColumns; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int currentSum = 0;
            for (int row = 0; row < totalRows-2; row++)
            {
                for (int col = 0; col < totalColumns-2; col++)
                {
                    for (int rowIn = row; rowIn <= row+2; rowIn++)
                    {
                        for (int colIn = col; colIn <= col+2 ; colIn++)
                        {
                            currentSum += matrix[rowIn, colIn];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                    currentSum = 0;
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int rowIn = maxRow; rowIn < maxRow + 3; rowIn++)
            {
                for (int colIn = maxCol; colIn < maxCol + 3; colIn++)
                {
                    Console.Write($"{matrix[rowIn, colIn]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
