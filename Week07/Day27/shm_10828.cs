using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _20230201
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            Stack<string> stack = new Stack<string>();
            int loop = int.Parse(sr.ReadLine());
            for(int i = 0; i < loop; i++)
            {
                string[] input = sr.ReadLine().Split();
                switch (input[0])
                {
                    case "push":
                        stack.Push(input[1]);
                        break;
                    case "top":
                        if (stack.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(stack.Peek());
                        break;
                    case "size":
                        sb.AppendLine(stack.Count.ToString());
                        break;
                    case "empty":
                        if (stack.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "pop":
                        if (stack.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(stack.Pop());
                        break;
                }
            }
            sw.Write(sb);
        }
    }
}
