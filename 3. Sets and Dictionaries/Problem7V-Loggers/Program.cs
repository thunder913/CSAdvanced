using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem7V_Loggers
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggerFollowing = new Dictionary<string, List<string>>();
            var vloggerFollowers = new Dictionary<string, List<string>>();
            var input = Console.ReadLine().Split(" ");
            while (input[0] != "Statistics")
            {
                if (input[1] == "joined")
                {
                    var name = input[0];
                    if (!vloggerFollowing.ContainsKey(name))
                    {
                        vloggerFollowing.Add(name, new List<string>());
                        vloggerFollowers.Add(name, new List<string>());
                    }
                }
                else if (input[1] == "followed")
                {
                    var currentVlogger = input[0];
                    var toFollow = input[2];
                    if (vloggerFollowing.ContainsKey(currentVlogger) && vloggerFollowing.ContainsKey(toFollow) && currentVlogger != toFollow)
                    {
                        if (!vloggerFollowing[currentVlogger].Contains(toFollow))
                        {
                            vloggerFollowing[currentVlogger].Add(toFollow);
                            vloggerFollowers[toFollow].Add(currentVlogger);
                        }
                    }
                }

                input = Console.ReadLine().Split(" ");
            }

            vloggerFollowing = vloggerFollowing.OrderBy(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            vloggerFollowers = vloggerFollowers.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            var vloggers = new List<Vlogger>();
            foreach (var (key, value) in vloggerFollowing)
            {
                Vlogger current = new Vlogger();
                current.name = key;
                current.following = value.Count();
                current.followers = vloggerFollowers[key].Count();
                vloggers.Add(current);
            }

            vloggers = vloggers.OrderByDescending(x => x.followers).ThenBy(x => x.following).ToList();
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count()} vloggers in its logs.");
            for (int i = 0; i < vloggers.Count(); i++)
            {
                Console.WriteLine($"{i+1}. {vloggers[i].name} : {vloggers[i].followers} followers, {vloggers[i].following} following");
                if (i==0)
                {
                    var maxName = vloggers[0].name;
                    vloggerFollowers[maxName] = vloggerFollowers[maxName].OrderBy(x => x).ToList();
                    foreach (var item in vloggerFollowers[maxName])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
            }           
        }
        public class Vlogger
        {
            public string name;
            public int followers;
            public int following;

        };
    }
}
