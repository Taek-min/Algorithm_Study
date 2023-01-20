using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230120
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            int loop = int.Parse(sr.ReadLine());
            string[,] score = new string[loop, 3];
            int[] res = new int[loop];

            for(int i = 0; i < score.GetLength(0); i++)
            {
                string[] input = sr.ReadLine().Split();
                for(int j = 0; j < score.GetLength(1); j++) score[i, j] = input[j];
            }

            for (int i = 0; i < score.GetLength(1); i++)
            {
                for (int j = 0; j < score.GetLength(0); j++)
                {
                    bool overlap = false;
                    for (int k = 0; k < score.GetLength(0); k++)
                    {
                        if (k == j) continue;
                        if (score[j, i].Equals(score[k, i])) overlap = true;
                    }
                    if (!overlap) res[j] += int.Parse(score[j, i]);
                }
            }

            foreach (int num in res) sb.AppendLine(num.ToString());

            sw.Write(sb);
        }
    }
}
