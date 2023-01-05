using System;

namespace kcm_1654
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(); // 0값은 보유 랜선 개수, 1값이 필요 랜선 개수
            long[] nums = new long[long.Parse(str[0])];

            for(int j = 0; j < nums.Length; j++)
            {
                nums[j] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);
            long Start = 0;
            long End = nums[nums.Length - 1] + 1;
            long max = 0;

            while (Start  + 1 < End)
            {
                long mid = (Start + End) / 2;

                if (Check(mid, max, nums, str))
                {
                    Start = mid;

                    if(mid > max)
                    {
                        max = mid;
                    }
                    
                }
                else
                {
                    End = mid;
                }
            }

            Console.WriteLine(max);
        }

        static bool Check(long mid, long max, long[] nums, string [] str)
        {
            long LANline = 0; 

            for(int i = 0; i < nums.Length; i++)
            {
                LANline += nums[i] / mid;
            }

            if(LANline < int.Parse(str[1]))
            {
                return false;
            }
            else
            { 
                return true;
            }
            
        }  
    }
}
