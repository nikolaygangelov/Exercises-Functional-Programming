using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            Predicate<int> evenOrOddFunc = number => number % 2 == 0;
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (evenOrOddFunc(i))
                {
                    evenList.Add(i);
                }
                else
                {
                    oddList.Add(i);
                }
            }

            if (command == "even")
            {
                Console.WriteLine(string.Join(' ', evenList));
            }
            else
            {
                Console.WriteLine(string.Join(' ', oddList));

            }
        }
    }
}
