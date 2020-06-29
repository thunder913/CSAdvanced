using System;
using System.Linq;
namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalRows = int.Parse(Console.ReadLine());
            var jaggedArray = new double[totalRows][];
            for (int i = 0; i < totalRows; i++)
            {
                var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedArray[i] = input;
            }
            for (int i = 0; i < totalRows-1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i+1].Length)
                {
                    for (int col = 0; col < jaggedArray[i].Length; col++)
                    {
                        jaggedArray[i][col] *= 2;
                    }
                    for (int col = 0; col < jaggedArray[i+1].Length; col++)
                    {
                        jaggedArray[i + 1][col] *= 2;
                    }
                }
                else 
                {
                    for (int col = 0; col < jaggedArray[i].Length; col++)
                    {
                        jaggedArray[i][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[i + 1].Length; col++)
                    {
                        jaggedArray[i + 1][col] /= 2;
                    }
                }
            }
            var command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int column = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if ((row >= 0 && row <= totalRows - 1) && (column >= 0 && column <= jaggedArray[row].Length-1))
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[row][column] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedArray[row][column] -= value;
                    }
                }

                command = Console.ReadLine().Split();
            }

            for (int row = 0; row < totalRows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
