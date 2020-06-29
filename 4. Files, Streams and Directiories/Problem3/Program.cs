using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var allWords = File.ReadAllText("text.txt").Split(new char[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var wordsToCheck = File.ReadAllText("words.txt").Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < allWords.Count(); i++)
            {
                allWords[i] = allWords[i].ToLower();
                for (int k = 0;  k < allWords[i].Length;  k++)
                {
                    if (allWords[i][k] < 'a' || allWords[i][k] > 'z')
                    {
                        allWords[i] =  allWords[i].Replace(allWords[i][k], ' ');
                        allWords[i] =  allWords[i].Trim();
                    }

                }
            }

            for (int i = 0; i < wordsToCheck.Count(); i++)
            {
                wordsToCheck[i] = wordsToCheck[i].ToLower();
            }
            var dictionary = new Dictionary<string, int>();
            foreach (var item in wordsToCheck)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 0);
                }
            }
            
            for (int i = 0; i < dictionary.Count(); i++)
            {
                var word = dictionary.ElementAt(i).Key;
                foreach (var item in allWords)
                {
                    if (item.Equals(word))
                    {
                        dictionary[word]++;
                    }
                }
            }
            var sbActualyResult = new StringBuilder();
            foreach (var item in dictionary)
            {
                File.AppendAllText("expectedResult.txt", $"{item.Key} - {item.Value}\n");
            }
            dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in dictionary)
            {
                File.AppendAllText("actualResult.txt", $"{item.Key} - {item.Value}\n");
            }

        }
    }
}
