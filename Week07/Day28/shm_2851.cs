using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230202
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int sum = 0;
            int total = 100;
            bool chk = false;
            for(int i = 0; i < 10; i++)
            {
                int mushroom = int.Parse(sr.ReadLine());
                if (chk) continue;
                sum += mushroom;

                if (sum == total)
                {
                    sb.Append(sum);
                    chk = true;
                }
                else if (sum > total)
                {
                    if (Math.Abs(total - sum) > Math.Abs(total - (sum - mushroom))) sb.Append(sum - mushroom);
                    else sb.Append(sum);
                    chk = true;
                }
                else if (sum < total) if (i == 9) sb.Append(sum);
            }
            sw.WriteLine(sb);
        }
    }
}
