using System;

namespace kcm_2798
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(); // index [ 0 : 숫자 개수 | 1 : 합 최대치 ]
            string[] nums = Console.ReadLine().Split();
            int max = 0;

            for(int i = 0; i < int.Parse(str[0]); i++)
            {
                for(int j  = i + 1; j < int.Parse(str[0]); j++)
                {
                    for(int k = j + 1; k < int.Parse(str[0]); k++)
                    {
                        int num = int.Parse(nums[i]) + int.Parse(nums[j]) + int.Parse(nums[k]);

                        if(max < num && num <= int.Parse(str[1]))
                        {
                            max = num;
                        }
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
