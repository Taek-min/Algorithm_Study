using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            bool[] nums = new bool[int.Parse(str[1]) + 1];
            StringBuilder strBuilder = new StringBuilder();

            if (int.Parse(str[1]) == 1)
            {
                return;
            }

            for (int i = 2; i <= int.Parse(str[1]); i++)
            {
                nums[i] = true;
            }

            for (int j = 2; j * j <= int.Parse(str[1]); j++)
            {
                if (nums[j])
                {
                    for (int k = j * j; k <= int.Parse(str[1]); k += j)
                    {
                        nums[k] = false;
                    }
                }
            }

            for (int l = int.Parse(str[0]); l <= int.Parse(str[1]); l++)
            {
                if (nums[l])
                {
                    strBuilder.Append(l + "\n");
                }
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}