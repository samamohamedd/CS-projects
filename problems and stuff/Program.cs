using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems_and_stuff
{
    internal class Program
    {
        public static void getPairs(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + " , " + array[j]);
                }
            }
        }
        static void Main(string[] args)
        {

            int [] array = new int[] {1,2,3,4,5};
            getPairs(array);
        }
    }
}
