using System;
using System.Collections.Generic;
using System.Linq;
namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int removeCount = 0;
            int boardSize = int.Parse(Console.ReadLine());
            var matrix = new char[boardSize, boardSize];
            var dictionary = new Dictionary<string, int>();
            var knightCoords = new List<string>();
            for (int row = 0; row < boardSize; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < boardSize; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'K')
                    {
                        knightCoords.Add(row.ToString() + col.ToString());
                        string place = row.ToString() + col.ToString();
                    }
                }
            }
        Start:;
            for (int i = 0; i < knightCoords.Count; i++)
            {
                int row = knightCoords[i][0] - 48;
                int col = knightCoords[i][1] - 48;
                if (row + 2 < boardSize)
                {
                    if (col + 1 < boardSize && matrix[row + 2, col + 1] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                    if (col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                }
                if (row - 2 >= 0)
                {
                    if (col + 1 < boardSize && matrix[row - 2, col + 1] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                    if (col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                }
                if (col + 2 < boardSize)
                {
                    if (row + 1 < boardSize && matrix[row + 1, col + 2] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                    if (row - 1 >= 0 && matrix[row - 1, col + 2] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                }
                if (col - 2 >= 0)
                {
                    if (row + 1 < boardSize && matrix[row + 1, col - 2] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
                    if (row - 1 >= 0 && matrix[row - 1, col - 2] == 'K')
                    {
                        AttackingKnightsAdd(row, col, dictionary);
                    }
            }
        }

            dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            if (dictionary.Any())
            {
                string maxKey = dictionary.Keys.ElementAt(0);
                int row = (maxKey[0] - 48);
                int col = (maxKey[1] - 48);
                removeCount++;
                knightCoords.Remove(maxKey);
                matrix[row, col] = '0';
                dictionary[maxKey] = 0;
                dictionary.Clear();

                goto Start;
            }
            else
            {
                Console.WriteLine(removeCount);
            }
        }
        static void AttackingKnightsAdd(int row, int col, Dictionary<string, int> dict)
        {
            string knightCoords = row.ToString() + col.ToString();
            if (!dict.ContainsKey(knightCoords))
            {
                dict.Add(knightCoords, 1);
            }
            else
            {
                dict[knightCoords]++;
            }
        }
    }
}