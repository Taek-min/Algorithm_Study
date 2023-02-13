using System;
using System.Linq;
using System.Text;
using System.IO;
namespace _20230213
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int[] num = sr.ReadLine().Split().Select(int.Parse).ToArray();
            sb.Append(Factorial(num[0]) / (Factorial(num[1]) * Factorial(num[0] - num[1])));
            sw.WriteLine(sb);
        }
        static public int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
    }
}
