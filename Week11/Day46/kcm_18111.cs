using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace kcm_18111
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[][] mine = new int[num[0]][];
            int maxHigh = 0;
            int minHigh = 255;
            int maxTime = int.MaxValue;
            int high = 0;

            for (int i = 0; i < num[0]; i++)
            {
                mine[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (mine[i].Min() < minHigh) { minHigh = mine[i].Min(); }
                if (mine[i].Max() > maxHigh) { maxHigh = mine[i].Max(); }
            }

            for (int j = minHigh; j <= maxHigh; j++)
            {
                int inventory = num[2];
                int remove = 0;
                int put = 0;

                for (int k  = 0; k < num[0]; k++)
                {
                    for(int l = 0; l < num[1]; l++)
                    { 
                        if(mine[k][l] > j) 
                        {
                            remove += mine[k][l] - j;
                        }
                        else if (mine[k][l] < j)
                        {
                            put += j - mine[k][l];
                        }
                    }
                }

                inventory += remove;

                if(put <= inventory)
                {
                    if (maxTime >= (remove * 2) + put)
                    {
                        maxTime = (remove * 2) + put;
                        high = j;
                    }
                }
            }

            Console.WriteLine("{0} {1}", maxTime, high);
        }
    }
}
