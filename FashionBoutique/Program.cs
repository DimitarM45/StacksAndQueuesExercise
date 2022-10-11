using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> clothesStack = new Stack<int>(clothes);

            int rackCapacity = int.Parse(Console.ReadLine());

            int clothesSum = 0;
            int rackCounter = 1;

            while (clothesStack.Count > 0)
            {
                if (clothesStack.Peek() + clothesSum < rackCapacity)
                    clothesSum += clothesStack.Pop();

                else if (clothesStack.Peek() + clothesSum == rackCapacity)
                {
                    clothesSum += clothesStack.Pop();

                    if (clothesStack.Count > 0)
                    {
                        clothesSum = 0;

                        rackCounter++;
                    }
                }

                else
                {
                    clothesSum = 0;

                    rackCounter++;
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}
