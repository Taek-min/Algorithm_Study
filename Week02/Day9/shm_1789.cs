using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _221230
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Truncate((-1.0 + Math.Sqrt(1.0 + 8.0 * num)) / 2.0));
        }
    }
}
