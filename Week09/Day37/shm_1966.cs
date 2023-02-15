using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20230215
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
                Queue<int> queue = new Queue<int>();
                Queue<int> num = new Queue<int>();
                int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                int[] importance = sr.ReadLine().Split().Select(int.Parse).ToArray();
                int cnt = 0;
                bool chk = false;
                
                for (int j = 0; j < input[0]; j++)
                {
                    queue.Enqueue(importance[j]);
                    num.Enqueue(j);
                }

                while (true)
                {
                    if (chk) break;
                    else if (queue.Max() == queue.Peek())
                    {
                        cnt++;
                        for (int k = 0; k < queue.Count; k++)
                            if (num.Peek() == input[1]) chk = true;
                        queue.Dequeue();
                        num.Dequeue();
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                        num.Enqueue(num.Dequeue());
                    }
                }
                sb.AppendLine(cnt.ToString());
            }
            sw.Write(sb);
        }
    }
}
