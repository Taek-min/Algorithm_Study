using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230125
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            
            List<int> list = new List<int>();
            int loop = int.Parse(sr.ReadLine());
            for(int i = 0; i < loop; i++) list.Add(int.Parse(sr.ReadLine()));
            list.Sort();

            foreach (int num in list) sb.AppendLine(num.ToString());
            sw.Write(sb);
        }
    }
}
