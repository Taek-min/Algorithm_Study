using System;
using System.Collections.Generic;
using System.Collections;

namespace kcm_1764
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            var hashtable = new Hashtable();
            List<string> hearinlook = new List<string>();

            for(int i = 0; i < int.Parse(str[0]) + int.Parse(str[1]); i++)
            {
                string name = Console.ReadLine();
                if (hashtable.Contains(name))
                {
                    hearinlook.Add(name);
                }
                else
                {
                    hashtable.Add(name, name);
                }
            }

            hearinlook.Sort();

            Console.Write(hearinlook.Count);

            for(int j = 0; j < hearinlook.Count; j++)
            { 
                Console.Write("\n");
                Console.Write(hearinlook[j]);
            }  
        }
    }
}
