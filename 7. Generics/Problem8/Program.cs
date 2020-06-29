using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            var input= Console.ReadLine().Split().ToList();
            var name = input[0] + " " + input[1];
            var street = input[2];
            var city = "";
            for (int i = 3; i < input.Count(); i++)
            {
                city += input[i] + " ";
            }
            var firstThreeuple = new Threeuple<string, string, string>() { item1 = name, item2 = street, item3 = city };
            input = Console.ReadLine().Split().ToList();
            name = input[0];
            int litres = int.Parse(input[1]);
            var isDrung = false;
            if (input[2] == "drunk")
            {
                isDrung = true;
            }

            var secondThreeuple = new Threeuple<string, int, bool>() { item1 = name, item2 = litres, item3 = isDrung};
            input = Console.ReadLine().Split().ToList();
            name = input[0];
            double accountBalance = double.Parse(input[1]);
            var bankName = input[2];
            var thirdThreeuple = new Threeuple<string, double, string>() { item1 = name, item2 = accountBalance, item3 = bankName };

            Console.WriteLine($"{firstThreeuple.item1} -> {firstThreeuple.item2} -> {firstThreeuple.item3}");
            Console.WriteLine($"{secondThreeuple.item1} -> {secondThreeuple.item2 } -> {secondThreeuple.item3}");
            Console.WriteLine($"{thirdThreeuple.item1} -> {thirdThreeuple.item2} -> {thirdThreeuple.item3}");
        }
    }
}
