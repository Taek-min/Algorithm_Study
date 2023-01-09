using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230109
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] min = new int[num + 1];
            min[1] = 0;

            for (int i = 2; i <= num; i++)
            {
                min[i] = min[i - 1] + 1;

                if (i % 3 == 0 && min[i] > min[i / 3] + 1)
                    min[i] = min[i / 3] + 1;

                if (i % 2 == 0 && min[i] > min[i / 2] + 1)
                    min[i] = min[i / 2] + 1;
            }

            Console.WriteLine(min[num]);
        }
    }
}