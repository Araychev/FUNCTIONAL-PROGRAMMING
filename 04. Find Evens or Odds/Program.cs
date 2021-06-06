using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bonds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var querry = Console.ReadLine();

            Predicate<int> predicate = querry == "odd"
                ? new Predicate<int>
                (number => number % 2 != 0)
                : new Predicate<int>(number => number % 2 == 0);

            var result = new List<int>();

            for (int number = bonds[0]; number <= bonds[1]; number++)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
