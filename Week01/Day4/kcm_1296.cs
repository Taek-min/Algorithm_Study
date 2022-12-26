using System;

namespace kcm_1296
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Love = { "L", "O", "V", "E" };
            string YeonDO = Console.ReadLine();
            int[] Lovecount = new int[Love.Length]; 
            int count = int.Parse(Console.ReadLine());
            string[] Teamname = new string[count];
            string choicename = "";
            int max = -1;
            for(int i = 0; i < count; i++)
            {
                Teamname[i] = Console.ReadLine();
            }

            Array.Sort(Teamname);
            for (int n = 0; n < Teamname.Length; n++)
            {
                for (int j = 0; j < Love.Length; j++)
                {
                    Lovecount[j] = Teamname[n].Split(Love[j]).Length - 1 + YeonDO.Split(Love[j]).Length - 1;
                }

                int win = ((Lovecount[0] + Lovecount[1]) * (Lovecount[0] + Lovecount[2]) * (Lovecount[0] + Lovecount[3]) * (Lovecount[1]
                    + Lovecount[2]) * (Lovecount[1] + Lovecount[3]) * (Lovecount[2] + Lovecount[3])) % 100;

                if (win > max)
                {
                    max = win;
                    choicename = Teamname[n];
                }
            }

            Console.WriteLine(choicename);
        }
    }// 깔끔하게 잘풀었네요
}
