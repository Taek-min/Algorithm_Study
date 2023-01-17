using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_1874
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] nums = new int[int.Parse(num)];
            Stack<int> stack = new Stack<int>();
            List<int> checknum = new List<int>();
            StringBuilder strBuilder = new StringBuilder();
            int index = 0;
            int count = 2;
            bool check = true;
            

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            stack.Push(1);
            strBuilder.Append("+\n");

            while (index < int.Parse(num))
            {
                if (stack.Count > 0)
                {
                    if (stack.Peek() - nums[index] > 0)
                    {
                        strBuilder.Append("-\n");
                        check = false;
                        break;
                    }
                    else if (stack.Peek() - nums[index] < 0)
                    {
                        strBuilder.Append("+\n");
                        stack.Push(count);
                        count++;
                    }
                    else
                    {
                        index++;
                        strBuilder.Append("-\n");
                        checknum.Add(stack.Peek());
                        stack.Pop();
                    }
                }
                else
                {
                    strBuilder.Append("+\n");
                    stack.Push(count);
                    count++;
                }
            }

            if (check)
            {
                Console.WriteLine(strBuilder);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }//비슷하게 풀었꾼요
    }
}
