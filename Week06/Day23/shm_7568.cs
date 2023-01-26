using System;
using System.Text;
using System.IO;

namespace _20230126
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
            int[,] human_info = new int[loop, 2];
            int[] rank = new int[loop];
            for (int i = 0; i < loop; i++)
            {
                string[] input = sr.ReadLine().Split();
                for (int j = 0; j < human_info.GetLength(1); j++) human_info[i, j] = int.Parse(input[j]);
            }

            for(int i = 0; i < loop; i++)
            {
                for(int j = 0; j < loop; j++)
                {
                    if (i == j) continue;
                    if(human_info[i, 0] < human_info[j, 0])
                    {
                        if(human_info[i, 1] < human_info[j, 1])
                        {
                            rank[i]++;
                        }
                    }
                }
            }
            foreach (int num in rank) sb.Append(num + 1 + " ");
            sw.WriteLine(sb);
        }
    }
}
