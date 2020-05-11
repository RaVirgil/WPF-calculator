using System;
using System.Collections.Generic;

namespace MVP_Tema1
{
    class Utils
    {        
        private static string PolishForm(string infix)
        {

            string[] tokens = infix.Split(' ');
            Stack<string> stack = new Stack<string>();
            string postfix = "";
            int n;

            foreach (string i in tokens)
            {
                if (int.TryParse(i.ToString(), out n))
                {
                    postfix += i;
                    postfix += " ";
                }

                if (IsOperator(i) == true)
                {
                    while (stack.Count != 0 && Priority(stack.Peek()) >= Priority(i))
                    {
                        postfix += stack.Pop();
                        postfix += " ";
                    }
                    stack.Push(i);
                }
            }

            while (stack.Count != 0)
            {
                postfix += stack.Pop();
                postfix += " ";
            }

            return postfix;
        }
        public static string PolishFormCalculate(string infix)
        {
            string postfix = PolishForm(infix);

            if (postfix == null || postfix.Length < 6)
                return postfix;

            string[] tokens = postfix.Split(' ');
            var stack = new Stack<int>();
            var operations = "+-*/^";

            foreach (string i in tokens)
            {
                if (i != "")
                {
                    if (!operations.Contains(i))
                    {
                        stack.Push(Int32.Parse(i));
                    }
                    else
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();

                        switch (i.ToCharArray()[0])
                        {
                            case '+':
                                stack.Push(a + b);
                                break;
                            case '-':
                                stack.Push(a - b);
                                break;
                            case '*':
                                stack.Push(a * b);
                                break;
                            case '/':
                                if (b != 0)
                                {
                                    stack.Push(a / b);
                                    break;
                                }
                                return "ERROR";
                            case '^':
                                stack.Push((int)Math.Pow(a, b));
                                break;
                            case '√':
                                stack.Push((int)Math.Sqrt(a));
                                break;

                        }
                    }
                }
            }

            return stack.Pop().ToString();
        }
        public static string AddOperand(string x, string inputOperand)
        {
            if (x.Length == 0)
                return x+"";
            if (x.Length == 1)
                return x+inputOperand;
            if (x.Length == 2)
                return x + inputOperand;
            if (x.Length > 2)
            {
                string[] operands = { " + ", " / ", " * ", " - ", " ^ " };
                foreach (string i in operands)
                {
                    if (x.Substring(x.Length - 3, 3).Equals(i))
                        return x + "";

                }
                return x + inputOperand;
            }
            return x + "";
        }
        public static bool IsOperator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/" || c == "^")

                return true;

            return false;
        }
        public static int Priority(string c)
        {
            if (c == "^")
            {
                return 3;
            }
            else if (c == "*" || c == "/")
            {
                return 2;
            }
            else if (c == "+" || c == "-")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static string ClearText(string input)
        {

            if (input.Length > 0)
                input = input.Remove(input.Length - 1, 1);
            return input;
        }
    }
}
