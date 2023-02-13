using System;

namespace kcm_2748
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = int.Parse(Console.ReadLine());

            long[] fibonachi = new long[num + 1];
            fibonachi[0] = 0;
            fibonachi[1] = 1;

            for(int i = 2; i <= num; i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }

            Console.WriteLine(fibonachi[num]);

        }
    }
}
