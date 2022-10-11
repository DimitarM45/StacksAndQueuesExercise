using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queryCount = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 1; i <= queryCount; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (commands[0])
                {
                    case 1:
                        int element = commands[1];

                        numbers.Push(element);
                        break;

                    case 2:
                        if (numbers.Count > 0) numbers.Pop();
                        break;

                    case 3:
                        if (numbers.Count > 0)
                            Console.WriteLine(numbers.Max());
                        break;

                    case 4:
                        if (numbers.Count > 0)
                            Console.WriteLine(numbers.Min());
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
