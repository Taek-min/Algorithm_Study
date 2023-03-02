using System;
using System.Linq;
using System.Text;
using System.IO;
namespace _20230302
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
                bool chk = false;
                string[] input = sr.ReadLine().Split();
                char[] first = input[0].ToCharArray();
                char[] second = input[1].ToCharArray();
                Array.Sort(first);
                Array.Sort(second);
                if (first.Length != second.Length) chk = true;
                else
                {
                    for (int j = 0; j < first.Length; j++)
                    {
                        if (first[j] != second[j])
                        {
                            chk = true;
                            break;
                        }
                    }
                }
              
                if (!chk) sb.AppendLine(input[0] + " & " + input[1] + " are anagrams.");
                else sb.AppendLine(input[0] + " & " + input[1] + " are NOT anagrams.");
            }
            sw.Write(sb);
        }
    }
}
