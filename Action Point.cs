using System;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> printStrings = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));
            printStrings(strings);
        }
    }
}
