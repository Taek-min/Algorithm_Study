using System;
using System.Text;
using System.Numerics;
using System.IO;
namespace _20230221
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int num = int.Parse(sr.ReadLine());
            int cnt = 0;
            int index = Factorial(num).ToString().Length - 1;
            while (true)
            {
                if (Factorial(num).ToString().Substring(index, 1).Equals("0")) cnt++;
                else break;
                index--;
            }
            sb.Append(cnt);
            sw.WriteLine(sb);
        }
        static BigInteger Factorial(int N)
        {
            if (N == 0) return 1;
            else return Factorial(N - 1) * N;
        }
    }
}
