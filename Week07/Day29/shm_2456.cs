using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230203
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            sw.AutoFlush = true;
            int loop = int.Parse(sr.ReadLine());
            int[] score = new int[3];
            double[] rank = new double[3];
            double max = 0;
            int index = 0;
            int index2 = 0;
            int cnt = 0;
            for(int i = 0; i < loop; i++)
            {
                int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < score.Length; j++)
                {
                    score[j] += input[j];
                    switch (j)
                    {
                        case 0:
                            rank[j] += Math.Pow(input[j], 2);
                            break;
                        case 1:
                            rank[j] += Math.Pow(input[j], 2);
                            break;
                        case 2:
                            rank[j] += Math.Pow(input[j], 2);
                            break;
                    }
                }
            }

            for (int i = 0; i < rank.Length; i++)
            {
                if (max < rank[i])
                {
                    max = rank[i];
                    index = i;
                    index2 = i + 1;
                }
                for(int j = i + 1; j < 3; j++)
                {
                    if (i == j) continue;
                    if (rank[i] == rank[j]) cnt++;
                }
            }
           
            if (cnt >= 2) index2 = 0;
            else if (cnt == 1) if (score[index] > Math.Min(Math.Min(score[0], score[1]), Math.Min(score[1], score[2]))) index2 = 0;
            sw.WriteLine("{0} {1}", index2, score[index]);
        }
    }
}
