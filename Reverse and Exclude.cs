using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                //.Where(match(n, x))
                .ToList();
            int n = int.Parse(Console.ReadLine());
            Func<int, int, bool> match = (currentNumber, n) => currentNumber % n == 0;

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> reversedNumbers = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    int currentNumber = numbers[i];
                    if (!match(currentNumber, n))
                    {
                        reversedNumbers.Add(currentNumber);
                    }
                }
                return reversedNumbers;
            };
            Console.WriteLine(string.Join(' ', reverse(numbers)));
        }

    }
}
