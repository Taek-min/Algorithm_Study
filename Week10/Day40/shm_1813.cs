using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _20230220
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int loop = int.Parse(sr.ReadLine());
            int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int[] num = input.Distinct().ToArray();
            int[] cnt = new int[51];
            for(int i = 0; i < num.Length; i++)
                for(int j = 0; j < input.Length; j++)
                    if (num[i] == input[j]) cnt[num[i]]++;

            for (int i = cnt.Length - 1; i >= 0; i--)
            {
                if (cnt[0] > 0 && i == 0)
                {
                    sb.Clear();
                    sb.Append(-1);
                    break;
                }
                else if (cnt[i] == i)
                {
                    sb.Clear();
                    sb.Append(i);
                    break;
                }
                else
                {
                    sb.Clear();
                    sb.Append(0);
                }
            }
            sw.WriteLine(sb);
        }
    }
}
