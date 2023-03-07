using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230307
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
            int[] numArray = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sum = new int[input[0] + 1];
            int accum = 0;
            sum[0] = 0;

            for(int i = 1; i < sum.Length; i++)
            {
                accum += numArray[i - 1];
                sum[i] = accum;
            }

            for(int  i = 0; i < input[1]; i++)
            {
                int[] range = sr.ReadLine().Split().Select(int.Parse).ToArray();
                sb.AppendLine((sum[range[1]] - sum[range[0] - 1]).ToString());
            }
            sw.Write(sb);
        }
    }
}
