using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace _230102
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            string[] testCase = sr.ReadLine().Split();
            var hastable = new Hashtable();
            List<string> overlap = new List<string>();

            for(int i = 0; i < int.Parse(testCase[0]); i++)
            {
                string dontLis = sr.ReadLine();
                hastable.Add(dontLis, dontLis);
            }

            for(int i = 0; i < int.Parse(testCase[1]); i++)
            {
                sb.Append(sr.ReadLine());
                if (hastable.Contains(sb.ToString())) overlap.Add(sb.ToString());
                sb.Clear();
            }
            overlap.Sort();
            sw.WriteLine(overlap.Count);
            foreach (string name in overlap)
            {
                sw.WriteLine(name);
            }
        }
    }
}
