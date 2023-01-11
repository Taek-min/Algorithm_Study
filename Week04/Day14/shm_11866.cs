using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230111
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < int.Parse(num[0]); i++) queue.Enqueue(i + 1);

            while (true)
            {
                for (int i = 0; i < int.Parse(num[1]) - 1; i++) queue.Enqueue(queue.Dequeue());
                if (queue.Count == 1)
                {
                    sb.Append(queue.Dequeue());
                    break;
                }
                sb.Append(queue.Dequeue());
                sb.Append(", ");
            }
            Console.WriteLine("<{0}>", sb);
        }
    }
}
