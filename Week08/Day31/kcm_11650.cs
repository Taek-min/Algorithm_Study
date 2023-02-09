using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace kcm_11650
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strBuilder = new StringBuilder();
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int loop = int.Parse(sr.ReadLine());
            List<List<int>> list = new List<List<int>>();
            int[] xArr = new int[loop];
            int[] yArr = new int[loop];

            for (int i = 0; i < loop; i++)
            {
                string[] str = sr.ReadLine().Split();

                xArr[i] = int.Parse(str[0]);
                yArr[i] = int.Parse(str[1]);
            }

            Array.Sort(xArr, yArr);
            list.Add(new List<int> { xArr[0], yArr[0] });

            for (int j = 1; j < loop; j++)
            {
                if(xArr[j - 1] < xArr[j])
                {
                    list.Add(new List<int> { xArr[j], yArr[j] });
                }
                else
                {
                    bool check = true;

                    for (int k = 0; k < list.Count; k++)
                    {
                        
                        if (k == 0 && yArr[j] < list[k][1] && xArr[j] == list[k][0])
                        {
                            list.Insert(0, new List<int> { xArr[j], yArr[j] });
                            check = false;
                            break;
                        }
                        else if(yArr[j] < list[k][1] && xArr[j] == list[k][0])
                        {
                            list.Insert(k, new List<int> { xArr[j], yArr[j] });
                            check = false;
                            break;
                        }
                    }

                    if (check)
                    {
                        list.Add(new List<int> { xArr[j], yArr[j] });
                    }
                }
            }

            for(int l = 0; l < list.Count; l++)
            {
                strBuilder.Append(list[l][0] + " " + list[l][1] + "\n");
            }

            sw.Write(strBuilder.ToString());
        }
    }
}
