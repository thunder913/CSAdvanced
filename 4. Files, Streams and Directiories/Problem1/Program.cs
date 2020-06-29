using System;
using System.IO;
using System.Linq;
namespace _04FilesAndStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("file.txt")) 
            {
                string line = reader.ReadLine();
                while(line!= null)
                {
                    var splittedLine = line.Split().Reverse();
                    foreach (var word in splittedLine)
                    {
                        foreach (var letter in word)
                        {
                            if (letter.Equals('-') || letter.Equals(',') || letter.Equals('.') || letter.Equals('!') || letter.Equals('?'))
                            {
                                Console.Write("@");
                            }
                            else 
                            {
                                Console.Write(letter);
                            }
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    line = reader.ReadLine();
                }
            }
        }
    }
}
