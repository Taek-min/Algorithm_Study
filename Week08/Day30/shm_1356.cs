using System;
using System.Text;
using System.IO;
namespace _20230206
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            string input = sr.ReadLine();
            bool chk = false;
            for(int i = 1; i < input.Length; i++)
            {
                int frontSum = 1;
                int backSum = 1;
                char[] frontNum = input.Substring(0, i).ToCharArray();
                char[] backNum = input.Substring(i).ToCharArray();
                foreach(char c in frontNum) frontSum *= int.Parse(c.ToString());
                foreach (char c in backNum) backSum *= int.Parse(c.ToString());

                if (frontSum == backSum) chk = true; 
            }
            if (chk) sb.Append("YES");
            else sb.Append("NO");

            sw.WriteLine(sb);
        }
    }
}
