using System;
using System.Linq;
namespace Problem3Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new MyStack<string>();
            var command = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (command[0] != "END")
            {
                if (command[0] == "Push")
                {
                    command.RemoveAt(0);
                    myStack.Push(command);
                }
                else 
                {
                    if (myStack.Pop() == null)
                    {
                        Console.WriteLine($"No elements");
                    }
                }
                command = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
