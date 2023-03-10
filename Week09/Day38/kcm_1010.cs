using System;
using System.Text;
using System.Linq;
using System.Numerics;

namespace kcm_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int loop = int.Parse(Console.ReadLine());

            for(int i = 0; i < loop; i++)
            {
                BigInteger count = 0;
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(nums);

                count = Factorial(nums[1]) / (Factorial(nums[1] - nums[0]) * Factorial(nums[0]));

                sb.Append(count + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
        static BigInteger Factorial(BigInteger num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

    }
}
