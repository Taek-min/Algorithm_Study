using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_10845
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < loop; i++)
            {
                string[] order = Console.ReadLine().Split();

                switch (order[0])
                {
                    case "push":
                        {
                            queue.Enqueue(int.Parse(order[1]));
                            break;
                        }

                    case "pop":
                        {
                            if (queue.Count != 0)
                            {
                                sb.Append(queue.Dequeue() + "\n");
                            }
                            else
                            {
                                sb.Append("-1\n");
                            }
                            break;
                        }
                    case "size":
                        {
                            sb.Append(queue.Count + "\n");
                            break;
                        }
                    case "empty":
                        {
                            if (queue.Count != 0)
                            {
                                sb.Append("0\n");
                            }
                            else
                            {
                                sb.Append("1\n");
                            }
                            break;
                        }
                    case "front":
                        {
                            if (queue.Count != 0)
                            {
                                sb.Append(queue.Peek() + "\n");
                            }
                            else
                            {
                                sb.Append("-1\n");
                            }
                            break;
                        }
                    case "back":
                        {
                            if (queue.Count != 0)
                            {
                                int[] nums = queue.ToArray();

                                sb.Append(nums[nums.Length - 1] + "\n");
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
