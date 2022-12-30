using System;

namespace kcm_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xy = Console.ReadLine().Split();
            string[,] Board = new string[int.Parse(xy[0]),int.Parse(xy[1])];
            int min = 64;
            int x = 0;
            int y = 0;


            for (int i = 0; i < int.Parse(xy[0]); i++)
            {
                string str = Console.ReadLine();
                char[] charArr = str.ToCharArray();

                for (int n = 0; n < charArr.Length; n++)
                {
                    Board[i, n] = charArr[n].ToString();
                }
            }

            while (true)
            {
                int BlackStart = 0;
                int WhiteStart = 0;
                bool WStart = false;
                bool BStart = false;

                for (int j = 0 + y; j < y + 8; j++)
                {
                    for (int k = 0 + x; k < x + 8; k++)
                    {
                        if (((j - y) + (k - x)) % 2 == 0)
                        {
                            //처음이 W 시작일 때
                            if(Board[j, k].Equals("B"))
                            {
                                WhiteStart++;
                            }

                            //처음이 B 시작일 때
                            if (Board[j, k].Equals("W"))
                            {
                                BlackStart++;
                            }
                        }
                        else if(((j - y) + (k - x)) % 2 == 1)
                        {
                            //처음이 B 시작일 때
                            if (Board[j, k].Equals("B") )
                            {
                                BlackStart++;
                            }
                            //처음이 W 시작일 때
                            if (Board[j, k].Equals("W"))
                            {
                                WhiteStart++;
                            }
                        }
                    }
                }

                if(BlackStart > WhiteStart)
                {
                    if(min > WhiteStart)
                    {
                        min = WhiteStart;
                    }
                }
                else
                {
                    if(min > BlackStart)
                    {
                        min = BlackStart;
                    }
                }

                x++;

                if( 8 + x > int.Parse(xy[1]))
                {
                    x = 0;
                    y++;

                    if(8 + y > int.Parse(xy[0]))
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(min);
        }
    }
}
