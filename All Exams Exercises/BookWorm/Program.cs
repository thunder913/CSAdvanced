using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine();
            sb.Append(input);
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];
            int playerRow = 0, playerCol = 0;
            for (int row = 0; row < size; row++)
            {
                var currentRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (currentRow[col]== 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            var command = Console.ReadLine();
            while (command!="end")
            {
                matrix[playerRow, playerCol] = '-';
                if (command=="up")
                {
                    playerRow--;
                }
                else if (command=="down")
                {
                    playerRow++;
                }
                else if (command=="left")
                {
                    playerCol--;
                }
                else if (command=="right")
                {
                    playerCol++;
                }
                bool isItOutside = false;
                (playerRow, playerCol, isItOutside) = isOutside(playerRow, playerCol, size);
                if (isItOutside)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else if(matrix[playerRow,playerCol] != '-') 
                {
                    sb.Append(matrix[playerRow, playerCol]);
                }
                matrix[playerRow, playerCol] = 'P';
                command = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString());
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        public static (int,int,bool) isOutside(int row, int col, int size) 
        {
            if (row < 0) 
            {
                return (0,col,true);
            }
            else if (row>=size)
            {
                return (row-1, col, true);
            }
            else if (col<0)
            {
                return (row, 0, true);
            }
            else if (col>= size)
            {
                return (row, col - 1, true);
            }
            return (row,col,false);
        }
    }
}
