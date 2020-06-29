using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var printList = new List<string>();
            var frog = new Froggy<string>(Console.ReadLine().Split(new char[] {',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList());
            foreach (var item in frog)
            {
                printList.Add(item);
            }

            Console.WriteLine(string.Join(", ", printList));
        }
    }
}
