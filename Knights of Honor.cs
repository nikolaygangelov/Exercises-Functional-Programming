using System;
using System.Text;

namespace _2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string> print = item => Console.WriteLine($"Sir {item}");

            foreach (string item in names)
            {
                print(item);
            }
        }
    }
}
