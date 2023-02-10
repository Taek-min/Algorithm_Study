using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230210
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int input = int.Parse(sr.ReadLine());
            int[] num = new int[input + 1];
            num[1] = 1;
            for(int i = 2; i <= input; i++) num[i] = num[i - 1] + num[i - 2];
            sb.Append(num[input]);
            sw.WriteLine(sb);
        }
    }
}
