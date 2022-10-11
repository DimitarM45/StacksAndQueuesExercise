using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bracketSequence = Console.ReadLine();

            if (bracketSequence.Length % 2 != 0)
            {
                Console.WriteLine("NO");

                return;
            }

            List<char> brackets = new List<char>();

            for (int i = 0; i < bracketSequence.Length; i++)
                brackets.Add(bracketSequence[i]);

            Stack<char> openingBrackets = new Stack<char>();

            bool matchesBracket;

            for (int i = 0; i < brackets.Count; i++)
            {
                matchesBracket = true;

                switch (brackets[i])
                {
                    case ')':
                        if (openingBrackets.Pop() != '(')
                            matchesBracket = false;
                        break;

                    case ']':
                        if (openingBrackets.Pop() != '[')
                            matchesBracket = false;
                        break;

                    case '}':
                        if (openingBrackets.Pop() != '{')
                            matchesBracket = false;
                        break;

                    default:
                        openingBrackets.Push(brackets[i]);
                        break;
                }

                if (!matchesBracket)
                {
                    Console.WriteLine("NO");

                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
