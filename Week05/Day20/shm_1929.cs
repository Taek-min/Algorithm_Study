using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;    
using System.Text;
using System.Threading.Tasks;

namespace _20230119
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            string[] input = sr.ReadLine().Split();
            int[] array = new int[int.Parse(input[1]) + 1];
            for (int i = 2; i <= int.Parse(input[1]); i++) array[i] = i;

            for(int i = 2; i <= Math.Sqrt(int.Parse(input[1])); i++)
                for(int j = i * i; j <= int.Parse(input[1]); j = j + i) array[j] = 0;

            for(int i = int.Parse(input[0]); i <= int.Parse(input[1]); i++) 
                if (array[i] != 0) sb.AppendLine(array[i].ToString());
            
            sw.Write(sb);
        }
    }
}
