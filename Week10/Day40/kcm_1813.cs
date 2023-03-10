using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcm_1813
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool check = false;
            int max = 0;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }

                if (count == nums[i])
                {
                    check = true;
                    max = nums[i];
                }
            }

            if (nums[0] == 0 && !check)
            {
                Console.WriteLine("-1");
            }
            else if (check)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
