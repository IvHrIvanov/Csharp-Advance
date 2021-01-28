using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Stack<string> stack = new Stack<string>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {

                string curr = input[i].ToString();

                if (curr == "(" || curr == "[" || curr == "{")
                {
                    stack.Push(curr);
                }
                else if (curr == ")" || curr == "]" || curr == "}")
                {
                    if (!stack.Any() && input.Length > 0)
                    {
                        flag = false;
                        break;
                    }

                    string parentheses = stack.Pop();

                    if (parentheses == "(" && curr == ")")
                    {
                        flag = true;
                    }

                    else if (parentheses == "{" && curr == "}")
                    {
                        flag = true;
                    }
                    else if (parentheses == "[" && curr == "]")
                    {
                        flag = true;
                    }

                    else
                    {
                        flag = false;
                        break;
                    }
                }

            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}