using System;

namespace kcm_1356
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            bool check = true;

            if (line.Length != 1)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    char[] LeftStr = line.Substring(0, i).ToCharArray();
                    char[] RightStr = line.Substring(i).ToCharArray();
                    int[] sum = { 1, 1 };

                    for(int j = 0; j < LeftStr.Length; j++)
                    {
                        int num = int.Parse(LeftStr[j].ToString());
                        sum[0] *= num;
                    }

                    for(int k = 0; k < RightStr.Length; k++)
                    {
                        int num = int.Parse(RightStr[k].ToString());
                        sum[1] *= num;
                    }

                    if(sum[0] == sum[1])
                    {
                        Console.WriteLine("YES");
                        check = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("NO");
                check = false;
            }

            if (check)
            {
                Console.WriteLine("NO");
            }
        }
    }
}
