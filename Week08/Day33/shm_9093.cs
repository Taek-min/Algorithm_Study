using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230209
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
                string[] input = sr.ReadLine().Split();
                for(int j = 0; j < input.Length; j++)
                {
                    char[] ch = input[j].ToCharArray();
                    Array.Reverse(ch);
                    string str = new string(ch);
                    sb.Append(str + " ");
                }
                sb.Append("\n");
            }
            sw.Write(sb);
        }
    }
}
