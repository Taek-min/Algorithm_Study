using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221228
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            var list = new List<word>();
            List<string> distinctList = new List<string>();

            for (int i = 0; i < loop; i++)
            {
                var input = new word();
                input.str = Console.ReadLine();
                input.wordLength = input.str.Length;
                list.Add(input);
            }
            list = list.OrderBy(x => x.wordLength).ThenBy(x => x.str).ToList();
            
            foreach(word wordobj in list) distinctList.Add(wordobj.str);

            distinctList = distinctList.Distinct().ToList();
            
            foreach(string s in distinctList) Console.WriteLine(s);
        }
        class word
        {
            public string str { get; set; }
            public int wordLength { get; set; }
        }
    }
}
