using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _20230131
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int num1 = int.Parse(sr.ReadLine());
            int[] N = sr.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(N);

            int num2 = int.Parse(sr.ReadLine());
            int[] M = sr.ReadLine().Split().Select(int.Parse).ToArray();

            foreach(int num in M)
            {
                int fIndex = 0;
                int bIndex = num1 - 1;
                bool isContain = false;

                while (true)
                {
                    if (fIndex > bIndex) break;
                    int mIndex = (fIndex + bIndex) / 2;
                    if (num == N[mIndex])
                    {
                        isContain = true;
                        sb.AppendLine("1");
                        break;
                    }
                    else if (num > N[mIndex]) fIndex = mIndex + 1;
                    else bIndex = mIndex - 1;
                }
                if (!isContain) sb.AppendLine("0");
            }
            sw.Write(sb);
        }
    }
}
