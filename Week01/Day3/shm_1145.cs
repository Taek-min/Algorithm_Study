using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221222
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] num = Console.ReadLine().Split();
            int multiple = 1;
            while (true)
            {
                int chk = 0;
                for(int i = 0; i < num.Length; i++)
                {
                    if (multiple % int.Parse(num[i]) == 0) chk++;
                }
                if(chk >= 3)
                {
                    Console.WriteLine(multiple);
                    break;
                }
                multiple++;
            }
        }
    }
}
