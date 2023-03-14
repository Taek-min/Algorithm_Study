using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace kcm_2108
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> nums = new List<int>();
            List<int> count = new List<int>();
            StringBuilder sb = new StringBuilder();
            int secondNum = 0;
            int num = 0;
            int stack = 0;
            int index = -1;
            bool chk = false;

            int loop = int.Parse(Console.ReadLine());

            for(int i = 0; i < loop; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort();
            
            for(int j = 0; j < list.Count; j++)
            {
                if (!nums.Contains(list[j]))
                {
                    index++;
                    nums.Add(list[j]);
                    count.Add((int)1);
                }
                else
                {
                    count[index]++;
                }
            }
            if(Math.Round((double)list.Sum() / loop) > -0.5)
            {
                sb.Append(Math.Abs(Math.Round((double)list.Sum() / loop)) + "\n");
            }
            else
            {
                sb.Append(Math.Round((double)list.Sum() / loop) + "\n");
            }
            
            sb.Append(list[list.Count / 2] + "\n");

            for (int k = 0; k < count.Count; k++)
            {

                if(count.Max() == count[k])
                {
                    stack++;
                    num = nums[k];

                    if (stack == 2)
                    {
                        secondNum = nums[k];
                        chk = true;
                    }
                }
            }

            if (chk)
            {
                sb.Append(secondNum + "\n");
            }
            else
            {
                sb.Append(num + "\n");
            }

            sb.Append(nums.Max() - nums.Min() + "\n");

            Console.WriteLine(sb.ToString());
        }
    }
}
