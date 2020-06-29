using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var path = Console.ReadLine();
            var fileNames = Directory.GetFiles(path);

            var dictionary = new Dictionary<string, Dictionary<string, float>>();
            foreach (var item in fileNames)
            {
                FileInfo current = new FileInfo(item);
                if (!dictionary.ContainsKey(current.Extension))
                {
                    dictionary.Add(current.Extension, new Dictionary<string, float>());
                }
                dictionary[current.Extension].Add(current.Name, current.Length);
            }

            dictionary = dictionary.OrderByDescending(x => x.Value.Count).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var (extension, files) in dictionary)
            {
                var toPrint = files.OrderBy(x=>x.Value).ToDictionary(kvp=>kvp.Key, kvp=>kvp.Value);
                Console.WriteLine(extension);
                foreach (var file in toPrint)
                {
                    var size = file.Value/1024;
                    Console.WriteLine($"--{file.Key} - {size}kb");
                }
            }
        }
    }
}
