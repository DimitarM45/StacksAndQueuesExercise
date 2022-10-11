using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<PetrolPump> pumps = new Queue<PetrolPump>();

            for (int i = 1; i <= numberOfPumps; i++)
            {
                int[] pumpInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(new PetrolPump(pumpInfo[0], pumpInfo[1]));
            }

            int currentPumpIndex = 0;

            while (true)
            {
                int currentLiters = 0;

                bool valid = true;

                for (int i = 0; i < pumps.Count; i++)
                {
                    PetrolPump currentPump = pumps.Dequeue();

                    currentLiters += currentPump.Liters;

                    currentLiters -= currentPump.Distance;

                    pumps.Enqueue(currentPump);

                    if (currentLiters < 0)
                        valid = false;
                }

                if (valid) break;

                pumps.Enqueue(pumps.Dequeue());

                if (currentPumpIndex == pumps.Count - 1)
                    currentPumpIndex = 0;

                else
                    currentPumpIndex++;
            }

            Console.WriteLine(currentPumpIndex);
        }
    }
}

class PetrolPump
{
    public PetrolPump(int liters, int distance)
    {
        Liters = liters;
        Distance = distance;
    }

    public int Liters { get; set; }

    public int Distance { get; set; }
}

