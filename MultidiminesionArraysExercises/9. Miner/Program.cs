using System;
using System.Linq;
namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split().ToArray();
            var array = new string[fieldSize, fieldSize];
            for (int row = 0; row < fieldSize; row++)
            {
                var mine = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < fieldSize; col++)
                {
                    array[row, col] = mine[col];
                }
            }

            int XplayerPos = 0;
            int YplayerPos = 0;
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (array[row, col] == "s")
                    {
                        XplayerPos = row;
                        YplayerPos = col;
                        goto Leave;
                    }
                }
            }
        Leave:;
            bool hitE = false;
            for (int i = 0; i < commands.Length; i++)
            {
                int currentPosX = XplayerPos;
                int currentPosY = YplayerPos;
                if (commands[i] == "up" && XplayerPos-1 >= 0)
                {
                    XplayerPos -= 1;
                }
                else if (commands[i] == "down" && XplayerPos+1 < fieldSize )
                {
                    XplayerPos += 1;
                }
                else if (commands[i] == "right" && YplayerPos+1 < fieldSize)
                {
                    YplayerPos += 1;
                }
                else if (commands[i] == "left" && YplayerPos-1 >=  0)
                {
                    YplayerPos -= 1;
                }
                
                if (array[XplayerPos, YplayerPos] == "c")
                {
                    array[XplayerPos, YplayerPos] = "*";
                }
                else if (array[XplayerPos, YplayerPos] == "e")
                {
                    hitE = true;
                    break;
                }
            }
            int coalsLeft = 0;
            if (hitE)
            {
                Console.WriteLine($"Game over! ({XplayerPos}, {YplayerPos})");
            }
            else
            {
                for (int row = 0; row < fieldSize; row++)
                {
                    for (int col = 0; col < fieldSize; col++)
                    {
                        if (array[row,col] == "c")
                        {
                            coalsLeft++;
                        }
                    }
                }
            }
            if (coalsLeft == 0 && !hitE)
            {
                Console.WriteLine($"You collected all coals! ({XplayerPos}, {YplayerPos})");
            }
            else
            {
                if (!hitE)
                {
                    Console.WriteLine($"{coalsLeft} coals left. ({XplayerPos}, {YplayerPos})");
                }
            }

        }
    }
}
