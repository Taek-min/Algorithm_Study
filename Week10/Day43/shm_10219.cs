using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230223
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
                int[] info = sr.ReadLine().Split().Select(int.Parse).ToArray();
                char[,] grid = new char[info[0], info[1]];
                for (int j = 0; j < info[0]; j++)
                {
                    string input = sr.ReadLine();
                    for (int k = 0; k < info[1]; k++)
                    {
                        grid[j, k] = input.ToCharArray()[k];
                    }
                }

                for (int j = 0; j < info[0]; j++)
                {
                    for (int k = info[1] - 1; k >= 0; k--) sb.Append(grid[j, k]);
                    sb.AppendLine();
                }
            }
            sw.Write(sb);
        }
    }
}
