using System;
using System.Linq;
using System.Collections.Generic;

namespace _1SantaPresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var magic = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var dict = new Dictionary<string, int>();
            
            while (magic.Any()&&materials.Any())
            {
                var currentSum = materials.Peek() * magic.Peek();
                if (materials.Peek() == 0 || magic.Peek() == 0)
                {
                    if (materials.Peek()==0)
                    {
                        materials.Pop();
                    }
                    if (magic.Peek()==0)
                    {
                        magic.Dequeue();
                    }
                    continue;
                }
                else if (currentSum < 0)
                {
                    materials.Push(materials.Pop()+magic.Dequeue());
                }
                else if (currentSum == 150)
                {
                    if (!dict.ContainsKey("Doll"))
                    {
                        dict.Add("Doll", 0);
                    }
                    dict["Doll"]++;
                    magic.Dequeue();
                    materials.Pop();
                }
                else if (currentSum == 250)
                {
                    if (!dict.ContainsKey("Wooden train"))
                    {
                        dict.Add("Wooden train", 0);
                    }
                        dict["Wooden train"]++; magic.Dequeue();
                    materials.Pop();
                }
                else if (currentSum == 300)
                {
                    if (!dict.ContainsKey("Teddy bear"))
                    {
                        dict.Add("Teddy bear", 0);
                    }
                        dict["Teddy bear"]++; magic.Dequeue();
                    materials.Pop();
                }
                else if (currentSum == 400)
                {
                    if (!dict.ContainsKey("Bicycle"))
                    {
                        dict.Add("Bicycle", 0);
                    }
                        dict["Bicycle"]++; magic.Dequeue();
                    materials.Pop();
                }
                else 
                {
                    magic.Dequeue();
                    materials.Push(materials.Pop() + 15);
                }
            }

            if ((dict.ContainsKey("Doll")&&dict.ContainsKey("Wooden train")) ||(dict.ContainsKey("Teddy bear")&&dict.ContainsKey("Bicycle")))
            {
                Console.WriteLine($"The presents are crafted! Merry Christmas!");
            }
            else 
            {
                Console.WriteLine($"No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magic.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magic)}");
            }

            dict = dict.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
