using System;
using System.Linq;
using System.Collections.Generic;

namespace _2PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNiceKidsCount = 0;
            var presentsCount = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];
            int santaRow = 0, santaCol = 0;
            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine().Split(" ");
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = char.Parse(input[col]);
                    if (matrix[row,col] == 'S')
                    {
                        santaRow = row; santaCol = col;
                    }
                    else if (matrix[row,col]=='V')
                    {
                        totalNiceKidsCount++;
                    }
                }
            }

            int niceKidPresents = 0;
            while (true)
            {
                var command = Console.ReadLine();
                if (command== "Christmas morning")
                {
                    break;
                }

                matrix[santaRow, santaCol] = '-';
                if (command=="up")
                {
                    santaRow--;
                }
                else if (command=="down")
                {
                    santaRow++;
                }
                else if (command == "left")
                {
                    santaCol--;
                }
                else if (command == "right")
                {
                    santaCol++;
                }

                if (matrix[santaRow,santaCol] == 'V')
                {
                    presentsCount--;
                    niceKidPresents++;
                }
                else if (matrix[santaRow,santaCol] == 'C')
                {
                    if (matrix[santaRow+1,santaCol] == 'V')
                    {
                        presentsCount--;
                        niceKidPresents++;
                    }
                    else if (matrix[santaRow+1,santaCol]=='X')
                    {
                        presentsCount--;
                    }

                    if (matrix[santaRow - 1, santaCol] == 'V')
                    {
                        presentsCount--;
                        niceKidPresents++;
                    }
                    else if (matrix[santaRow - 1, santaCol] == 'X')
                    {
                        presentsCount--;
                    }

                    if (matrix[santaRow, santaCol+1] == 'V')
                    {
                        presentsCount--;
                        niceKidPresents++;
                    }
                    else if (matrix[santaRow, santaCol+1] == 'X')
                    {
                        presentsCount--;
                    }
                    if (matrix[santaRow, santaCol-1] == 'V')
                    {
                        presentsCount--;
                        niceKidPresents++;
                    }
                    else if (matrix[santaRow, santaCol-1] == 'X')
                    {
                        presentsCount--;
                    }

                    matrix[santaRow + 1, santaCol] = '-';
                    matrix[santaRow - 1, santaCol] = '-';
                    matrix[santaRow, santaCol + 1] = '-';
                    matrix[santaRow, santaCol - 1] = '-';
                }

                matrix[santaRow, santaCol] = 'S';

                if (presentsCount==0)
                {
                    Console.WriteLine($"Santa ran out of presents!");
                    break;
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }

            if (totalNiceKidsCount== niceKidPresents)
            {
                Console.WriteLine($"Good job, Santa! {niceKidPresents} happy nice kid/s.");
            }
            else 
            {
                Console.WriteLine($"No presents for {totalNiceKidsCount-niceKidPresents} nice kid/s.");
            }
        }
    }
}
