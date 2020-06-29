using System;
using System.Text;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split();
            var listy = new ListyIterator<string>();

            for (int i = 1; i < command.Length; i++)
            {
                listy.list.Add(command[i]);
            }
            command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                if (command[0] == "Move")
                {
                    var hasMoved = listy.Move();
                    if (hasMoved)
                    {
                        Console.WriteLine($"True");
                    }
                    else { Console.WriteLine("False"); }
                }
                else if (command[0] == "Print")
                {
                    Console.WriteLine(listy.Print());
                }
                else if (command[0] == "HasNext")
                {
                    var hasMoved = listy.HasNext();
                    if (hasMoved)
                    {
                        Console.WriteLine($"True");
                    }
                    else { Console.WriteLine("False"); }
                }
                else if (command[0] == "PrintAll")
                {
                    var sb = new StringBuilder();
                    foreach (var item in listy)
                    {
                        sb.Append(item + " ");
                    }
                    Console.WriteLine(sb);
                }

                command = Console.ReadLine().Split();
            }

        }
    }
}
