using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operationCount = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            Stack<string> previousVersions = new Stack<string>();

            previousVersions.Push(string.Empty);

            for (int i = 1; i <= operationCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        string textToAppend = command[1];

                        text.Append(textToAppend);

                        previousVersions.Push(text.ToString());
                        break;

                    case "2":
                        int elementsToRemove = int.Parse(command[1]);

                        text.Remove(text.Length - elementsToRemove, elementsToRemove);

                        previousVersions.Push(text.ToString());
                        break;

                    case "3":
                        int index = int.Parse(command[1]);

                        Console.WriteLine(text[index - 1]);
                        break;

                    case "4":
                        text.Clear();

                        previousVersions.Pop();

                        text.Append(previousVersions.Peek());
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
