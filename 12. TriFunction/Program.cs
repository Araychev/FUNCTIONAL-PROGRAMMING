using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> validator = (name, value) =>
            name
            .ToCharArray()
            .Select(curchar => (int)curchar).Sum() >= n;

            Func< string[],int, Func<string, int, bool>, string > foundName =
                (collection, value, func) => collection
                .FirstOrDefault(name => func(name, value));

            Console.WriteLine(foundName(names, n, validator));
        }
    }
}
