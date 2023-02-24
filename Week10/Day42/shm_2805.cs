using System;
using System.Linq;
using System.Text;
using System.IO;
namespace _20230224
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
            int[] treeLen = sr.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(treeLen);
            int firstValue = 0;
            int lastValue = treeLen[input[0] - 1];
            while (true)
            {
                if (firstValue > lastValue)
                {
                    sb.Append(lastValue);
                    break;
                }
                long sum = 0;
                int midValue = (firstValue + lastValue) / 2;
                foreach(int num in treeLen)
                {
                    if (num < midValue) continue;
                    else sum += num - midValue;
                }

                if (sum >= input[1]) firstValue = midValue + 1;
                else lastValue = midValue - 1;
            }
            sw.WriteLine(sb);
        }
    }
}
