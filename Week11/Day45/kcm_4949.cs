using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_4949
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                Stack<string> bracket = new Stack<string>();
                string str = Console.ReadLine();
                char[] chars = str.ToCharArray();
                bool check = true;

                if (chars[0].Equals('.') && str.Length == 1)
                {
                    break;
                }

                for (int i = 0; i < chars.Length; i++)
                {
                    switch (chars[i]) {

                        case '(':
                            bracket.Push("(");
                            break;
                        case '[':
                            bracket.Push("[");
                            break;
                        case ')':
                            if (bracket.Count > 0)
                            {
                                if (bracket.Peek().Equals("("))
                                {
                                    bracket.Pop();
                                }
                                else
                                {
                                    check = false;
                                }
                            }
                            else
                            {
                                check = false;
                            }
                            break;
                        case ']':
                            if (bracket.Count > 0)
                            {
                                if (bracket.Peek().Equals("["))
                                {
                                    bracket.Pop();
                                }
                                else
                                {
                                    check = false;
                                }
                            }
                            else
                            {
                                check = false;
                            }
                            break;
                    }
                }

                if (bracket.Count == 0 && check )
                {
                    sb.Append("yes\n");
                }
                else if (bracket.Count != 0 || !check)
                {
                    sb.Append("no\n");
                }
            }

            Console.Write(sb.ToString());
        }
    }
}
