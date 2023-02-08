using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230208
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
            Queue<int> queue = new Queue<int>();
            for(int i = 0; i < loop; i++)
            {
                string[] input = sr.ReadLine().Split();
                string last = "";
                switch (input[0])
                {
                    case "push":
                        queue.Enqueue(int.Parse(input[1]));
                        break;
                    case "pop":
                        if (queue.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(queue.Dequeue().ToString());
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "empty":
                        if (queue.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "front":
                        if (queue.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(queue.Peek().ToString());
                        break;
                    case "back":
                        if (queue.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(queue.Last().ToString());
                        break;
                }
            }
            sw.Write(sb);
        }
    }
}
