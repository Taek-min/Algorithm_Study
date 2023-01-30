using System;
using System.Text;
using System.IO;

namespace _20230130
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
                string input = sr.ReadLine();
                while (true)
                {
                    if (!input.Contains("()")) break;
                    input = input.Replace("()", "");
                }

                if (input.Trim() == "") sb.AppendLine("YES");
                else sb.AppendLine("NO");
            }
            sw.Write(sb);
        }
    }
}
