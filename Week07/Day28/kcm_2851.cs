using System;
using System.Linq;

namespace kcm_2851
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int[] min = new int[2];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            min[0] = num.Sum();
            min[1] = num.Sum();

            for(int j = 0; j < num.Length; j++)
            {
                int sum = 0;

                for(int k = 0; k < num.Length; k++)
                {
                    sum += num[k];

                    if(Math.Abs(sum - 100) <= min[0])
                    {
                        min[0] = Math.Abs(sum - 100);
                        min[1] = sum;
                    }
                }
            }

            Console.WriteLine(min[1]);
        }
    }
}
