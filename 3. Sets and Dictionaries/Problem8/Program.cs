using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestPassword = new Dictionary<string, string>();
            var input = Console.ReadLine().Split(":").ToArray();
            while (input[0] != "end of contests")
            {
                if (!contestPassword.ContainsKey(input[0]))
                {
                    contestPassword.Add(input[0], input[1]);
                }
                input = Console.ReadLine().Split(":").ToArray();
            }

            input = Console.ReadLine().Split("=>").ToArray();
            var userDictPoints = new Dictionary<string, Dictionary<string, int>>();
            while (input[0] != "end of submissions")
            {
                //"{contest}=>{password}=>{username}=>{points}
                var contest = input[0];
                var password = input[1];
                var username = input[2];
                var points = int.Parse(input[3]);

                if (contestPassword.ContainsKey(contest) && contestPassword[contest] == password)
                {
                    if (!userDictPoints.ContainsKey(username))
                    {
                        userDictPoints.Add(username, new Dictionary<string, int>());
                        userDictPoints[username].Add(contest, points);
                    }
                    else if (!userDictPoints[username].ContainsKey(contest))
                    {
                        userDictPoints[username].Add(contest, points);
                    }
                    else 
                    {
                        if (points > userDictPoints[username][contest])
                        {
                            userDictPoints[username][contest] = points;
                        }
                    }
                }
                input = Console.ReadLine().Split("=>").ToArray();
            }

            var namePoints = new Dictionary<string, int>();
            foreach (var item in userDictPoints)
            {
                if (!namePoints.ContainsKey(item.Key))
                {
                    namePoints.Add(item.Key, 0);
                }
                foreach (var point in item.Value)
                {
                    namePoints[item.Key] += point.Value;
                }
            }

            namePoints = namePoints.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine($"Best candidate is {namePoints.ElementAt(0).Key} with total {namePoints.ElementAt(0).Value} points.");

            userDictPoints = userDictPoints.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine("Ranking:");
            for (int i = 0; i < userDictPoints.Count(); i++)
            {
                var item = userDictPoints.ElementAt(i);
                Console.WriteLine(item.Key);
                var competitionPoints = item.Value;
                competitionPoints = competitionPoints.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
                foreach (var points in competitionPoints)
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
