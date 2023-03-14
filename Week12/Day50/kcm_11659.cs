using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace kcm_11659
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] test = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sumNums = new int[test[0] + 1];

            sumNums[0] = 0;

            for(int i = 1; i < sumNums.Length; i++)
            {
                sumNums[i] = sumNums[i - 1] + nums[i - 1];
            }
            
            for(int j = 0; j < test[1]; j++)
            {
                int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

                sb.Append((sumNums[range[1]] - sumNums[range[0] - 1]) + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
