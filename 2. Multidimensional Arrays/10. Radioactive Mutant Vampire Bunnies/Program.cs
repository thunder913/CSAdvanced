using System;
using System.Linq;
using System.Collections.Generic;
namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasRanAway = false;
            var rowsColumns = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsColumns[0];
            int columns = rowsColumns[1];
            var matrix = new char[rows, columns];
            int XplayerPos = 0;
            int YPlayerPos = 0;
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        XplayerPos = row;
                        YPlayerPos = col;
                    }
                }
            }
            string directions = Console.ReadLine();
            bool hasHitBunny = false;
            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == 'U' && XplayerPos - 1 < 0)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    hasRanAway = true;
                }
                else if (directions[i] == 'D' && XplayerPos + 1 >= rows)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    hasRanAway = true;
                }
                else if (directions[i] == 'L' && YPlayerPos - 1 < 0)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    hasRanAway = true;
                }
                else if (directions[i] == 'R' && YPlayerPos + 1 >= columns)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    hasRanAway = true;
                }

                if (directions[i] == 'U' && XplayerPos - 1 >= 0 && !hasRanAway)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    XplayerPos -= 1;
                    if (matrix[XplayerPos, YPlayerPos] == 'B')
                    {
                        matrix[XplayerPos, YPlayerPos] = 'B';
                        hasHitBunny = true;
                    }
                    else
                    {
                        matrix[XplayerPos, YPlayerPos] = 'P';
                    }
                }
                else if (directions[i] == 'D' && XplayerPos + 1 < rows && !hasRanAway)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    XplayerPos += 1;
                    if (matrix[XplayerPos, YPlayerPos] == 'B')
                    {
                        matrix[XplayerPos, YPlayerPos] = 'B';
                        hasHitBunny = true;
                    }
                    else
                    {
                        matrix[XplayerPos, YPlayerPos] = 'P';
                    }
                }
                else if (directions[i] == 'L' && YPlayerPos - 1 >= 0 && !hasRanAway)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    YPlayerPos -= 1;
                    if (matrix[XplayerPos, YPlayerPos] == 'B')
                    {
                        matrix[XplayerPos, YPlayerPos] = 'B';
                        hasHitBunny = true;
                    }else
                    {
                        matrix[XplayerPos, YPlayerPos] = 'P';
                    }
                }
                else if (directions[i] == 'R' && YPlayerPos + 1 < columns && !hasRanAway)
                {
                    matrix[XplayerPos, YPlayerPos] = '.';
                    YPlayerPos += 1;
                    if (matrix[XplayerPos, YPlayerPos] == 'B')
                    {
                        matrix[XplayerPos, YPlayerPos] = 'B';
                        hasHitBunny = true;
                    }else
                    {
                        matrix[XplayerPos, YPlayerPos] = 'P';
                    }
                }
                var listX = new List<int>();
                var listY = new List<int>();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        
                        if (matrix[row, col] == 'B')
                        {
                            listX.Add(row);
                            listY.Add(col);
                        }
                    }
                }
                for (int k = 0; k < listX.Count; k++)
                {
                    int row = listX[k];
                    int col = listY[k];
                    if (matrix[row, col] == 'B')
                    {
                        if (row + 1 < rows)
                        {
                            if (matrix[row + 1, col] == 'P')
                            {
                                hasHitBunny = true;
                            }
                            else
                                matrix[row + 1, col] = 'B';
                        }
                        if (row - 1 >= 0)
                        {
                            if (matrix[row - 1, col] == 'P')
                            {
                                hasHitBunny = true;
                            }
                            else
                                matrix[row - 1, col] = 'B';
                        }
                        if (col + 1 < columns)
                        {
                            if (matrix[row, col + 1] == 'P')
                            {
                                hasHitBunny = true;
                            }
                            matrix[row, col + 1] = 'B';
                        }
                        if (col - 1 >= 0)
                        {
                            if (matrix[row, col - 1] == 'P')
                            {
                                hasHitBunny = true;
                            }
                            matrix[row, col - 1] = 'B';
                        }
                    }
                }
                if (hasHitBunny)
                {
                    break;
                }
                else if (hasRanAway == true)
                {
                    goto end;
                }
            }
        end:;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
            if (hasHitBunny)
            {
                Console.WriteLine($"dead: {XplayerPos} {YPlayerPos}");
            }
            else 
            {
                Console.WriteLine($"won: {XplayerPos} {YPlayerPos}");
            }
        }
    }
}
