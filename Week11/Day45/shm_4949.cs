using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace _20230227
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            while (true)
            {
                Stack<string> stack = new Stack<string>();
                string[] input = sr.ReadLine().Split();
                bool chk = true;
                if (input[0].Equals(".")) break;
                for(int i = 0; i < input.Length; i++)
                {
                    for(int j = 0; j < input[i].Length; j++)
                    {
                        if (input[i].Substring(j, 1) == "(" || input[i].Substring(j, 1) == "[")
                            stack.Push(input[i].Substring(j, 1));
                        else if (input[i].Substring(j, 1) == ")")
                        {
                            if (stack.Count == 0)
                            {
                                chk = false;
                                break;
                            }
                            else if (stack.Peek() == "(") stack.Pop();
                            else chk = false;
                        }
                        else if(input[i].Substring(j, 1) == "]")
                        {
                            if (stack.Count == 0)
                            {
                                chk = false;
                                break;
                            }
                            else if (stack.Peek() == "[") stack.Pop();
                            else chk = false;
                        }
                    }
                }
                if (stack.Count == 0 && chk) sb.AppendLine("yes");
                else if (stack.Count != 0 || !chk) sb.AppendLine("no");
            }
            sw.Write(sb);
        }
    }
}
