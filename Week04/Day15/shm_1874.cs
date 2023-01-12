using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230112
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            string[] seq = new string[loop];
            int index = 0;
            int cnt = 1;

            for(int i = 0; i < loop; i++) seq[i] = Console.ReadLine();

            stack.Push(cnt);
            sb.AppendLine("+");
            while (true)
            {
                if (index == loop) break;

                if (stack.Count > 0)
                {
                    if(stack.Peek() == int.Parse(seq[index]))
                    {
                        sb.AppendLine("-");
                        stack.Pop();
                        index++;
                        continue;
                    }
                    else
                    {
                        if (stack.Contains(int.Parse(seq[index])))
                        {
                            sb.Clear();
                            sb.AppendLine("NO");
                            break;
                        }
                    }
                }
                sb.AppendLine("+");
                stack.Push(++cnt);
            }
            Console.WriteLine(sb);
        }
    }
}
