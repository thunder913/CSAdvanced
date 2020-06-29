using System;
using System.Linq;
namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalRows = dimensions[0];
            int totalColumns = dimensions[1];
            var matrix = new string[totalRows, totalColumns];
            for (int row = 0; row < totalRows; row++)
            {
                var input = Console.ReadLine().Split();
                for (int col = 0; col < totalColumns; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                if (command.Length != 5 || command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else 
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    if (row1 > totalRows-1 || row1<0 || col1> totalColumns-1 || col1 < 0 || row2 > totalRows-1 || row2 < 0 || col2 > totalColumns-1 || col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else 
                    {
                        var fnum = matrix[row1, col1];
                        var snum = matrix[row2, col2];
                        matrix[row1, col1] = snum;
                        matrix[row2, col2] = fnum;
                        for (int row = 0; row < totalRows; row++)
                        {
                            for (int col = 0; col < totalColumns; col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
