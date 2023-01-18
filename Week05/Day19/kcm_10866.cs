using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_10866
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            List<int> deque = new List<int>();
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < loop; i++)
            {
               string[] order= Console.ReadLine().Split();

                switch (order[0])
                {
                    case "push_front":
                        {
                            deque.Insert(0, int.Parse(order[1]));
                            break;
                        }
                    case "push_back":
                        {
                            deque.Add(int.Parse(order[1]));
                            break;
                        }
                    case "pop_front":
                        {
                            if (deque.Count == 0)
                            {
                                strBuilder.Append("-1\n");
                            }
                            else
                            {
                                strBuilder.Append(deque[0] + "\n");
                                deque.RemoveAt(0);
                            }
                            break;
                        }
                    case "pop_back":
                        {
                            if (deque.Count == 0)
                            {
                                strBuilder.Append("-1\n");
                            }
                            else
                            {
                                strBuilder.Append(deque[deque.Count -1] + "\n");
                                deque.RemoveAt(deque.Count - 1);
                            }
                            break;
                        }
                    case "size":
                        {
                            strBuilder.Append(deque.Count + "\n");
                            break;
                        }
                    case "empty":
                        {
                            if(deque.Count == 0)
                            {
                                strBuilder.Append("1\n");
                            }
                            else
                            {
                                strBuilder.Append("0\n");
                            }
                            break;
                        }
                    case "front":
                        {
                            if (deque.Count == 0)
                            {
                                strBuilder.Append("-1\n");
                            }
                            else
                            {
                                strBuilder.Append(deque[0] + "\n");
                            }
                            break;
                        }
                    case "back":
                        {
                            if (deque.Count == 0)
                            {
                                strBuilder.Append("-1\n");
                            }
                            else
                            {
                                strBuilder.Append(deque[deque.Count - 1] + "\n");
                            }
                            break;
                        }
                }
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
