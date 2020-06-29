using System;
using System.Linq;
namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexInWord = 0;
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalRows = dimensions[0];
            int totalCol = dimensions[1];
            var matrix = new char[totalRows, totalCol];
            var input = Console.ReadLine().ToArray();
            for (int row = 0; row < totalRows; row++)
            {
                if (row%2 == 0)
                {
                    for (int col = 0; col < totalCol; col++)
                    {
                        if (indexInWord > input.Length-1)
                        {
                            indexInWord = 0;
                        }
                        matrix[row, col] = input[indexInWord];
                        indexInWord++;
                    }
                }
                else 
                {
                    for (int col = totalCol-1; col >= 0 ; col--)
                    {
                        if (indexInWord > input.Length - 1)
                        {
                            indexInWord = 0;
                        }
                        matrix[row, col] = input[indexInWord];
                        indexInWord++;
                    }
                }
            }

            for (int row = 0; row < totalRows; row++)
            {
                for (int col = 0; col < totalCol; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
