using System;
using System.Linq;
namespace MultidiminesionArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalRows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[totalRows, totalRows];
            for (int row = 0; row < totalRows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < totalRows; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int sumOne = 0, sumOther = 0;
            for (int i = 0; i < totalRows; i++)
            {
                sumOne += matrix[i, i];
            }
            int col1 = totalRows - 1;

            for (int row = 0; row < totalRows; row++)
            {
                sumOther += matrix[row, col1];
                col1--;
            }

            Console.WriteLine(Math.Abs(sumOne - sumOther));
        }
    }
}
