using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> filter = numbers => numbers % n != 0;
            Console.WriteLine(string.Join(" ", numbers
                .Reverse()
                .Where(x => filter(x))));

        }
    }
}
