﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject
{
    class syh_1145
    {
        static void Main()
        {
            const int inputLength = 5;
            int[] nums = InputMethod(inputLength).Select(int.Parse).ToArray();

            Array.Sort(nums);
            int curNum = nums[2];
            while (true)
            {
                int cnt = 0;
                for(int i = 0; i < inputLength; i++)
                {
                    cnt += curNum % nums[i] == 0 ? 1 : 0;
                }
                if (cnt < 3) curNum++;
                else break;
            }

            Console.WriteLine($"{curNum}");
        }

        static string[] InputMethod(int inputLength = 0)
        {
            while(true)
            {
                string[] inputStr = Console.ReadLine().Split(' ');
                if (inputStr.Length != inputLength && inputLength > 0)
                    continue;
                else
                    return inputStr;
            }//이게.. 뭐노? 배워간다 연호, C# 어려워!! :2
        }
    }
}
