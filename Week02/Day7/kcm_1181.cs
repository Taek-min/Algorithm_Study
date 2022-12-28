using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_1181
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> strList = new List<List<string>>();
            StringBuilder stringBuilder = new StringBuilder();

            int loop = int.Parse(Console.ReadLine());

            for(int n = 0; n < 51; n++)
            {
                strList.Add(new List<string>());
            }

            for(int i = 0; i < loop; i++)
            {
                string str = Console.ReadLine();

                if(!strList[str.Length - 1].Contains(str))
                {
                    strList[str.Length - 1].Add(str);
                }   
            }

            for(int j = 0; j < strList.Count; j++)
            {
                strList[j].Sort();

                for (int k = 0; k < strList[j].Count; k++)
                {
                    stringBuilder.Append(strList[j][k]);
                    stringBuilder.Append("\n");
                }
            }
            string strListToString = stringBuilder.ToString();

            Console.WriteLine(strListToString);
        }
    }
}
