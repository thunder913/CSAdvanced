using System;

namespace JoroJivotnoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0, sumNonPrime = 0;
            var input = Console.ReadLine();
            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isSimple = true;
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            isSimple = false;
                            break;
                        }
                    }
                    if (isSimple == true)
                    {
                        sumPrime += number;
                    }
                    else
                    {
                        sumNonPrime += number;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
