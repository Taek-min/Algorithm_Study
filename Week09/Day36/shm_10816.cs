using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230214
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int N = int.Parse(sr.ReadLine());
            string[] haveNum = sr.ReadLine().Split();

            int M = int.Parse(sr.ReadLine());
            string[] chkNum = sr.ReadLine().Split();
            int[] cnt = new int[20000001];
            int index = 1000000;

            for (int i = 0; i < N; i++) cnt[index + int.Parse(haveNum[i])]++;
            for (int i = 0; i < M; i++) sb.Append(cnt[index + int.Parse(chkNum[i])] + " ");
            sw.WriteLine(sb);
        }
    }
}
