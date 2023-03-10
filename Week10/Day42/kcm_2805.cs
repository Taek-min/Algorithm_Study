using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcm_2805
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] tree = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(tree);

            int Endpoint = tree[tree.Length - 1];
            int Startpoint = 0;
            long max = 0;

            while (Endpoint - Startpoint >= 0)
            {
                int middlepoint = (Endpoint + Startpoint) / 2;
                long sum = 0;
                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] >= middlepoint)
                    {
                        sum += (tree[i] - middlepoint);
                    }
                }

                if (sum >= num[1])
                {
                    max = middlepoint;
                    Startpoint = middlepoint + 1;
                }
                else if (sum < num[1])
                {
                    Endpoint = middlepoint - 1;
                }

            }

            Console.WriteLine(max);
        }
    }
}
