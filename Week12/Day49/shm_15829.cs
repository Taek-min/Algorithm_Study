using System;
using System.Text;
using System.IO;
namespace _20230306
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int len = int.Parse(sr.ReadLine());
            string str = sr.ReadLine();
            long m = 1234567891;
            long sum = 0;
            for (int i = 0; i < len; i++)
            {
                long num = str[i] - 96;
                long pow = 1;
                for (int j = 0; j < i; j++)
                {
                    pow *= 31;
                    pow %= m;
                }

                sum += num * pow;
                sum %= m;
            }
            sb.Append(sum);
            sw.WriteLine(sb);
        }
    }
}
