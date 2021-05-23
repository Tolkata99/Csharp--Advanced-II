using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = (Console.ReadLine());

            Stack<char> stack = new Stack<char>();
           

            for (int i = 0; i < parentheses.Length; i++)
            {
                stack.Push(parentheses[i]);
            }

            bool isTrue = false;

            while (true)
            {
                char CurrBrackets = stack.Peek();

                if(CurrBrackets == ')')
                {
                    
                    if(isTrue = stack.Contains('('))
                    {
                        stack.Pop();
                    }
                }
                else if(CurrBrackets == '}')
                {
                    if (isTrue = stack.Contains('{'))
                    {
                        stack.Pop();
                    }
                }
                else if(CurrBrackets == ']')
                {
                    if (isTrue = stack.Contains('['))
                    {
                        stack.Pop();
                    }
                }

                if(stack.Count == stack.Count / 2)
                {
                    break;
                }
            }

        }
    }
}
