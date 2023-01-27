using System;
using System.Text;
using System.IO;
namespace _20230127
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

            if (input.Contains("pi")) input = input.Replace("pi", " ");
            if (input.Contains("ka")) input = input.Replace("ka", " ");
            if (input.Contains("chu")) input = input.Replace("chu", " ");
 
            if (input.Trim() == "") sb.Append("YES");
            else sb.Append("NO");

            sw.WriteLine(sb);
        }
    }
}
