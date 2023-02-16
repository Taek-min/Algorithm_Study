using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Numerics;

namespace _20230216
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
            for(int i = 0; i < loop; i++)
            {
                BigInteger[] input = sr.ReadLine().Split().Select(BigInteger.Parse).ToArray();
                BigInteger result = Factorial(input[1]) / (Factorial(input[0]) * Factorial(input[1] - input[0]));
                sb.AppendLine(result.ToString());
            }
            sw.Write(sb);
        }

        static BigInteger Factorial(BigInteger N)
        {
            if (N == 0) return 1;
            else return N * Factorial(N - 1);
        }
    }
}
