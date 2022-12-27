using System;

namespace kcm_1233
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int[] nums = new int[int.Parse(str[0]) + int.Parse(str[1]) + int.Parse(str[2]) + 1];
            int max = 0;
            int index = 0;

            for (int i = 1; i <= int.Parse(str[0]); i++)
            {
                for(int j = 1; j <= int.Parse(str[1]); j++)
                {
                    for(int k = 1; k <= int.Parse(str[2]); k++)
                    {
                        nums[i + j + k]++;
                    }
                }
            }
            
            for(int l = 3; l < nums.Length; l++)
            {
                if (nums[l] > max)
                {
                    max = nums[l];
                    index = l;
                }
            }

            Console.WriteLine(index);
        }
    }
}
