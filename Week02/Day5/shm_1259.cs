using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221226
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String input = Console.ReadLine();
                if (input.Equals("0")) return;
                bool check = true;

                for(int i = 0; i < input.Length / 2; i++)
                {
                    if (input.Substring(i, 1).Equals(input.Substring(input.Length - 1 - i, 1))) continue;
                    else
                    {
                        check = false;
                        break;
                    }
                }
                //String frontNum = new String(input.Substring(0, input.Length / 2).ToCharArray().OrderByDescending(x => x).ToArray());
                //String backNum = new String(input.Substring(input.Length - input.Length / 2).ToCharArray().OrderByDescending(x => x).ToArray());
                //bool exception = input.Substring(input.Length - input.Length / 2).Equals(backNum);

                if (check) Console.WriteLine("yes");
                else Console.WriteLine("no");
            }
        }
    }
}
// 주석 부분만 지워주시면 깔끔