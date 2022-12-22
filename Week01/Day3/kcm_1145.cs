using System;

namespace kcm_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int[] nums = new int[str.Length];
            int count = 0;
            int min;
            for (int i = 0; i < str.Length; i++)
            {
                nums[i] = int.Parse(str[i]);
            }

            for (int num = 4; ; num++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if(num % nums[i] == 0)
                    {
                        count++;
                    }
                }

                if(count >= 3)
                {
                    min = num;
                    break;
                }

                count = 0;
            }
            Console.Write(min);
        }
    }
}