using System;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (n <= 0)
            {
                return;
            }

            Func<int[], int, bool> filter = (allDividers, number) =>
            {
                bool divisible = true;

                for (int i = 0; i < allDividers.Length; i++)
                {
                    if (number % allDividers[i] != 0)
                    {
                        divisible = false;
                        break;
                    }

                }

                return divisible;
            };
            int[] divisibleNubers = Enumerable
                .Range(1, n)
                .Where(number => filter(dividers, number))
                .ToArray();
            Console.WriteLine(string.Join(" ",divisibleNubers));

        }
    }
}
