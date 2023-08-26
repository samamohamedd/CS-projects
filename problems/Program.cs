using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{

    internal class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] array1 = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {

                for (int n = 0; n < nums.Length; i++)
                {
                    int result = nums[i] + nums[n];
                    if (result == target)
                    {

                        array1[0] = i;
                        array1[1] = n;

                    }

                }

            }
            return array1;
        }
        static void Main(string[] args)
        {
            try
            {
                int[] array1 = new int[] { 1, 2, 3 };

                int[] array2 = new int[2];
                //  array2 =  TwoSum(array1, 5);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
