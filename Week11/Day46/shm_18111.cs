using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230228
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            int B = input[2];
            int[,] ground = new int[N, M];
            int max = 0;
            int min = 256;
            int time = int.MaxValue;
            int high = 0;

            for(int i = 0; i < N; i++)
            {
                int[] info = sr.ReadLine().Split().Select(int.Parse).ToArray();
                if (max < info.Max()) max = info.Max();
                if (min > info.Min()) min = info.Min();
                for(int j = 0; j < M; j++)
                {
                    ground[i, j] = info[j];
                }
            }

            for(int i = min; i <= max; i++)
            {
                B = input[2];
                int remove = 0;
                int add = 0;
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < M; k++)
                    {
                        if (ground[j, k] == i) continue;
                        else if (ground[j, k] > i)
                        {
                            remove += ground[j, k] - i;
                            B += ground[j, k] - i;
                        }
                        else add += i - ground[j, k];
                    }
                }
                if (add > B) continue;
                else if (time >= remove * 2 + add)
                {
                    time = remove * 2 + add;
                    high = Math.Max(high, i);
                }
            }
            sb.Append(time + " " + high);
            sw.WriteLine(sb);
        }
    }
}
