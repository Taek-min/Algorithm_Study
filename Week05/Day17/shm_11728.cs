using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _20230116_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>();

            sw.AutoFlush = true;
            string[] input = sr.ReadLine().Split();
            int one = int.Parse(input[0]);
            int two = int.Parse(input[1]);

            string[] first = sr.ReadLine().Split();
            for (int i = 0; i < one; i++) list.Add(int.Parse(first[i]));

            string[] second = sr.ReadLine().Split();
            for (int i = one; i < one + two; i++) list.Add(int.Parse(second[i - one]));

            list.Sort();
            foreach (int N in list)
            {
                sb.Append(N + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
