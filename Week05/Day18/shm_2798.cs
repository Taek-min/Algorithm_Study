using System;
using System.IO;
namespace _20230117
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;
            string[] input = sr.ReadLine().Split();
            string[] testcase = sr.ReadLine().Split();
            int max = int.Parse(input[0]);
            int sum = 0;
            for (int i = 0; i < max - 2; i++)
            {
                for(int j = i + 1; j < max - 1; j++)
                {
                    for(int k = j + 1; k < max; k++)
                    {
                        int res = int.Parse(testcase[i]) + int.Parse(testcase[j]) + int.Parse(testcase[k]);
                        if (int.Parse(input[1]) >= res && sum < res)
                        {
                            sum = res;
                        }
                    }
                }
            }
            sw.WriteLine(sum);
        }
    }
}
