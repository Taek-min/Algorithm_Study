using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace kcm_1966
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int loop = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < loop; i++)
            {
                Queue queue = new Queue();
                Queue Copyqueue = new Queue();

                int[] testcase = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                bool[] index = new bool[testcase[0]];
                index[testcase[1]] = true;
                int count = 0;

                for (int k = 0; k < nums.Length; k++)
                {
                    queue.Enqueue(nums[k]);
                }

                Array.Sort(nums);
                
                for(int j = nums.Length - 1; j >= 0; j--)
                {
                    Copyqueue.Enqueue(nums[j]);
                }

                while (true)
                {
                    if (queue.Peek().Equals(Copyqueue.Peek()))
                    { 
                        queue.Dequeue();
                        Copyqueue.Dequeue();
                        count++;

                        if (index[0])
                        {
                            sb.Append(count + "\n");
                            break;
                        }
                        else
                        {
                            index[testcase[1]] = false;
                            testcase[1] = testcase[1] - 1;
                            index[testcase[1]] = true;
                        }
                    }
                    else
                    {
                        var ob = queue.Dequeue();
                        queue.Enqueue(ob);

                        if (index[0]) 
                        {
                            index[testcase[1]] = false;
                            testcase[1] = queue.Count - 1;
                            index[testcase[1]] = true;
                        }
                        else
                        {
                            index[testcase[1]] = false;
                            testcase[1] = testcase[1] - 1;
                            index[testcase[1]] = true;
                        }
                    }


                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
    