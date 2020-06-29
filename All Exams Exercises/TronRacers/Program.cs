using System;
using System.Linq;
using System.Collections.Generic;
namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];
            int firstRow = 0, firstCol = 0, secondRow = 0, secondCol = 0;
            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row,col] == 'f')
                    {
                        firstRow = row;
                        firstCol = col;
                    }
                    else if (matrix[row,col] ==  's')
                    {
                        secondRow = row;
                        secondCol = col;
                    }
                }
            }

            while (true)
            {
                var commands = Console.ReadLine().Split();
                var firstCommand = commands[0];
                (firstRow, firstCol) = MovePlayer(matrix, firstRow, firstCol, size, firstCommand);

                if (matrix[firstRow, firstCol] == 's')
                {
                    matrix[firstRow, firstCol] = 'x';
                    break;
                }
                else 
                {
                    matrix[firstRow, firstCol] = 'f';
                }
                
                var secondCommand = commands[1];
                (secondRow, secondCol) = MovePlayer(matrix, secondRow, secondCol, size, secondCommand);
                if (matrix[secondRow,secondCol] == 'f')
                {
                    matrix[secondRow, secondCol] = 'x';
                    break;
                }
                else 
                {
                    matrix[secondRow, secondCol] = 's';
                }
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        public static (int,int) MovePlayer(char[,] matrix, int row, int col, int size, string command) 
        {
            if (command == "up")
            {
                row--;
            }
            else if (command == "down")
            {
                row++;
            }
            else if (command == "left")
            {
                col--;
            }
            else if (command == "right")
            {
                col++;
            }
            row = InsideCheck(row, size);
            col = InsideCheck(col, size);
            return (row, col);
        }

        public static int InsideCheck(int number, int size) 
        {
            if (number < 0)
            {
                return size - 1;
            }
            else if (number >= size)
            {
                return 0;
            }
            return number;
        }
    }
}
