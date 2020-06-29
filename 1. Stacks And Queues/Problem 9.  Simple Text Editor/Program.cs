using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_9.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();
            int totalInput = int.Parse(Console.ReadLine());
            string[,] history = new string[105, 2];
            int historyCount = 0;
            for (int i = 0; i < totalInput; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                switch (int.Parse(command[0]))
                {
                    case 1:
                        var input = command[1];
                        history[historyCount, 0] = "1";
                        history[historyCount, 1] = input;
                        historyCount++;
                        foreach (var item in input)
                        {
                            stack.Push(item);
                        }
                        break;
                    case 2:
                        var toErase = int.Parse(command[1]);
                        history[historyCount, 0] = "2";
                        history[historyCount, 1] = "";
                        for (int k = 0; k < toErase && stack.Any(); k++)
                        {
                            history[historyCount,1] += stack.Pop();
                        }
                        historyCount++;
                        break;
                    case 3:
                        var index = int.Parse(command[1]);
                        var stackToArray = stack.ToArray();
                        Array.Reverse(stackToArray);
                        if (stackToArray.Length >= index)
                        {
                            Console.WriteLine(stackToArray[index - 1]);
                        }
                        break;
                    case 4:
                        if (historyCount > 0)
                        {
                            historyCount--;
                            if (history[historyCount, 0] == "1")
                            {
                                int toDeleteCount = history[historyCount, 1].Length;
                                for (int l = 0; l < toDeleteCount && stack.Any(); l++)
                                {
                                    stack.Pop();
                                }
                                history[historyCount, 0] = null;
                                history[historyCount, 1] = null;

                            }
                            else if (history[historyCount, 0] == "2")
                            {
                                var deletedString = history[historyCount, 1].ToArray();
                                Array.Reverse(deletedString);
                                foreach (var item in deletedString)
                                {
                                    stack.Push(item);
                                }

                                history[historyCount, 0] = null;
                                history[historyCount, 1] = null;
                            }
                        }
                        break;
                }
            }
        }
    }
}
