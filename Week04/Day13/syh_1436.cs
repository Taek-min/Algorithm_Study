﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class syh_1436
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int curIdx = 0;
            int curNum = 666;

            while(curIdx < N)
            {
                //666 들어간 숫자마다 curIdx++
                if (curNum.ToString().Contains("666"))
                {
                    curIdx++;
                }
                curNum++;
            }

            Console.WriteLine(--curNum);
        }
    }//피드백이 필요 없군요
}
