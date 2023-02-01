using System;
using System.Collections;
using System.Text;

namespace kcm_10828
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            string[] order = { "push", "pop", "size", "empty", "top" };
            StringBuilder sb = new StringBuilder();
            int loop = int.Parse(Console.ReadLine());

            for(int i = 0; i < loop; i++)
            {
                string[] str = Console.ReadLine().Split();

                switch (str[0])
                {
                    case "push":
                        {
                            stack.Push(int.Parse(str[1]));
                            break;
                        }
                    case "pop":
                        {
                            if (stack.Count != 0)
                            {
                               var num = stack.Pop();
                               sb.Append(num + "\n");
                            }
                            else
                            {
                                sb.Append("-1\n");
                            }
                            break;
                        }
                    case "size":
                        {
                            sb.Append(stack.Count + "\n");
                            break;
                        }
                    case "empty":
                        {
                            if (stack.Count != 0)
                            {
                                sb.Append("0\n");
                            }
                            else
                            {
                                sb.Append("1\n");
                            }
                            break;
                        }
                    case "top":
                        {
                            if(stack.Count != 0)
                            {
                                sb.Append(stack.Peek() + "\n");
                            }
                            else
                            {
                                sb.Append("-1\n");
                            }
                            break;
                        }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
