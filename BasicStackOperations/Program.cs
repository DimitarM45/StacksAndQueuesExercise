using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arguments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> integers = new Stack<int>(elements);

            int n = arguments[0];
            int elementsToRemove = arguments[1];
            int elementToFind = arguments[2];

            for (int i = 1; i <= elementsToRemove; i++)
            {
                integers.Pop();
            }

            if (integers.Count > 0)
            {
                if (integers.Contains(elementToFind))
                    Console.WriteLine("true");

                else
                    Console.WriteLine(integers.Min());
            }
            else
                Console.WriteLine(0);
        }
    }
}
