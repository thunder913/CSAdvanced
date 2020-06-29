using System;
using System.Linq;
using System.Collections.Generic;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var commandsCount = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];
            int rowPlayer = 0, colPlayer = 0;
            for (int row = 0; row < size; row++)
            {
                var inpput = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = inpput[col];
                    if (inpput[col] == 'f')
                    {
                        rowPlayer = row;
                        colPlayer = col;
                    }
                }
            }
            bool hasWon = false;
            for (int i = 0; i < commandsCount; i++)
            {
                var currentCommand = Console.ReadLine();
                RemovePosition(matrix, rowPlayer, colPlayer);
            Start:;
                if (currentCommand == "left")
                {
                    colPlayer--;
                    colPlayer = CheckPosition(colPlayer, size);
                    if (IsTrap(matrix,rowPlayer,colPlayer))
                    {
                        colPlayer++;
                        colPlayer = CheckPosition(colPlayer, size);
                    }
                }
                else if (currentCommand == "right")
                {
                    colPlayer++;
                    colPlayer = CheckPosition(colPlayer, size);
                    if (IsTrap(matrix,rowPlayer,colPlayer))
                    {
                        colPlayer--;
                        colPlayer = CheckPosition(colPlayer, size);
                    }
                }
                else if (currentCommand == "up")
                {
                    rowPlayer--;
                    rowPlayer = CheckPosition(rowPlayer, size);

                    if (IsTrap(matrix, rowPlayer, colPlayer))
                    {
                        rowPlayer++;
                        rowPlayer = CheckPosition(rowPlayer, size);
                    }
                }
                else if (currentCommand == "down")
                {
                    rowPlayer++;
                    rowPlayer = CheckPosition(rowPlayer, size);

                    if (IsTrap(matrix, rowPlayer, colPlayer))
                    {
                        rowPlayer--;
                        rowPlayer = CheckPosition(rowPlayer, size);
                    }
                }

                if (matrix[rowPlayer,colPlayer] == 'B')
                {
                    goto Start;
                }
                if (matrix[rowPlayer,colPlayer] == 'F')
                {
                    matrix[rowPlayer, colPlayer] = 'f';
                    hasWon = true;
                    break;
                }
                matrix[rowPlayer, colPlayer] = 'f';
            }
            if (hasWon)
            {
                Console.WriteLine($"Player won!");
            }
            else 
            {
                Console.WriteLine($"Player lost!");
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

        public static bool IsTrap(char[,] matrix, int row, int col) 
        {
            if (matrix[row,col] == 'T')
            {
                return true;
            }
            return false;
        }
        public static int CheckPosition(int number, int size) 
        {
            if (number < 0)
            {
                return size - 1;
            }
            else if (number>=size)
            {
                return 0;
            }
            return number;
        }
        public static void RemovePosition(char[,] matrix, int row, int col) 
        {
            matrix[row, col] = '-';
        }
    }
}
