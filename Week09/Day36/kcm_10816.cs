using System;
using System.Text;
using System.Linq;
using System.Collections;

namespace kcm_10816
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int haveCard = int.Parse(Console.ReadLine());
            int[] Cards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int loop = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Hashtable ht = new Hashtable();

            for(int i = 0; i < haveCard; i++)
            {
                if (ht.ContainsKey(Cards[i]))
                {
                    int num = (int)ht[Cards[i]] + 1;
                    ht.Remove(Cards[i]);
                    ht.Add(Cards[i], num);
                }
                else
                {
                    ht.Add(Cards[i], 1);
                }
            }

            for(int j = 0; j< loop; j++)
            {
                if (ht.ContainsKey(nums[j]))
                {
                    sb.Append(ht[nums[j]] + " ");
                }
                else
                {
                    sb.Append("0 ");
                }
            }
            
            Console.WriteLine(sb.ToString());
            
        }
    }
}
