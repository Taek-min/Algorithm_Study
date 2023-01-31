using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace kcm_1920
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();

            Array.Sort(A);

            for(int i = 0; i < nums.Length; i++)
            {
                int firstindex = 0;
                int secondindex = A.Length - 1;
                bool check = false;

                while (A[firstindex] <= int.Parse(nums[i]) && A[secondindex] >= int.Parse(nums[i]))
                {
                    int mid = (secondindex + firstindex) / 2;

                    if(int.Parse(nums[i]) == A[mid])
                    {
                        check = true;
                        break;
                    }
                    else if(int.Parse(nums[i]) > A[mid])
                    {
                        firstindex = mid + 1;
                    }
                    else if(int.Parse(nums[i]) < A[mid])
                    {
                        secondindex = mid - 1;
                    }
                }

                if(check)
                {
                    sb.Append("1\n");
                }
                else
                {
                    sb.Append("0\n");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
