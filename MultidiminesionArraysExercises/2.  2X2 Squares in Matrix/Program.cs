using System;
using System.Linq;
namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[dimension[0], dimension[1]];
            for (int row = 0; row < dimension[0]; row++)
            {
                var currentRow = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < dimension[1]; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            for (int row = 0; row < dimension[0]-1; row++)
            {
                for (int col = 0; col < dimension[1]-1; col++)
                {
                    string current = matrix[row, col];
                    if (current == matrix[row,col+1] && current == matrix[row+1, col] && current == matrix[row+1, col+1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }


    }
}
