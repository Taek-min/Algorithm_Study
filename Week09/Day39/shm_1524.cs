using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _20230217
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
                sr.ReadLine();
                int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                List<int> N = sr.ReadLine().Split().Select(int.Parse).ToList();
                List<int> M = sr.ReadLine().Split().Select(int.Parse).ToList();
                if (N.Max() >= M.Max()) sb.AppendLine("S");
                else sb.AppendLine("B");
            }
            sw.Write(sb);
        }
    }
}
