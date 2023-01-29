using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> numbers = new HashSet<int>(numbersInput);

            
            Func<HashSet<int>, int> minFunc = numbers =>
            {
                int minValue = int.MaxValue;
                foreach (int number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };
            Console.WriteLine(minFunc(numbers));
            
        }
    }
}
