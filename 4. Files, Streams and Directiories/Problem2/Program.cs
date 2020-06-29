using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "file.txt";
            var allLines = new List<string>();
            allLines = File.ReadAllLines(file).ToList();
            for (int i = 0; i < allLines.Count(); i++)
            {
                var currentLine = allLines[i];
                int letters = 0;
                int punctuations = 0;
                foreach (var item in currentLine)
                {
                    if ((item >= 'a' && item <= 'z') || (item>='A' && item<='Z'))
                    {
                        letters++;
                    }
                    else if(item != ' ')
                    {
                        punctuations++;
                    }
                }

                Console.WriteLine($"Line {i+1}: {currentLine} ({letters})({punctuations})");
            }
        }
    }
}
