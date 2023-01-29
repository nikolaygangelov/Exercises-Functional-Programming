using System;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = string.Empty;
            bool isPrinted = false;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        Func<int[], int, int> funcAdd = (numbers, i) => numbers[i] += 1;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            funcAdd(numbers, i);
                        }
                        break;
                    case "multiply":
                        Func<int[], int, int> funcMultiply = (numbers, i) => numbers[i] *= 2;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            funcMultiply(numbers, i);
                        }
                        break;
                    case "subtract":
                        Func<int[], int, int> funcSubtract = (numbers, i) => numbers[i] -= 1;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            funcSubtract(numbers, i);
                        }
                        break;
                    case "print":
                        Action<int[]> print = numbers => Console.WriteLine(string.Join(' ', numbers));
                        print(numbers);
                        isPrinted = true;
                        break;
                    default:
                        break;
                }
            }
            if (!isPrinted)
            {
                Console.WriteLine(string.Join(' ', numbers));

            }
        }
    }
}
