using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class syh_1789
    {
        static void Main()
        {
            long S = long.Parse(Console.ReadLine());
            long sum = 0;
            long i = 1;
            while(sum+i <= S)
            {
                sum += i++;
            }

            Console.WriteLine(--i);
        }
    }
}
