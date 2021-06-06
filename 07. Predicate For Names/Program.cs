using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> filter = name => name.Length <= n;
            foreach (var item in names.Where(x => filter(x)))
            {
                Console.WriteLine(item);
            }
           

        }
    }
}
