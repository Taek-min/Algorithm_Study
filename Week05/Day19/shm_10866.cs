using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _20230118
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            LinkedList<int> list = new LinkedList<int>();
            sw.AutoFlush = true; 
            int loop = int.Parse(sr.ReadLine());
            for(int i = 0; i < loop; i++)
            {
                string[] input = sr.ReadLine().Split();

                switch (input[0])
                {
                    case "front":
                        if (list.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(list.First.Value.ToString());
                        break;
                    case "back":
                        if (list.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(list.Last.Value.ToString());
                        break;
                    case "empty":
                        if (list.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "size":
                        sb.AppendLine(list.Count.ToString());
                        break;
                    case "push_front":
                        list.AddFirst(int.Parse(input[1]));
                        break;
                    case "push_back":
                        list.AddLast(int.Parse(input[1]));
                        break;
                    case "pop_front":
                        if (list.Count == 0) sb.AppendLine("-1");
                        else
                        {
                            sb.AppendLine(list.First.Value.ToString());
                            list.RemoveFirst();
                        }
                        break;
                    case "pop_back":
                        if (list.Count == 0) sb.AppendLine("-1");
                        else
                        {
                            sb.AppendLine(list.Last.Value.ToString());
                            list.RemoveLast();
                        }
                        break;
                }
            }
            sw.Write(sb);
        }
    
    }
}
