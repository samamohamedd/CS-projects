using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the end number");
            int endnum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= endnum; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + "is even");
                else Console.WriteLine(i + "is odd");
            }











            //Console.WriteLine("Please enter the end number");
            //Console.WriteLine("Please enter the end number");
            //int sum = 0;

            //for (int i = 0; i <= endnum; i++)
            //{
            //    sum = sum + i;

            //}
            //Console.WriteLine("final sum is "+ sum);








            //Console.WriteLine("How many sugar spoons do you want?");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("getting kanaka");
            //Console.WriteLine("putting coffee");

            //for (int i = 1; i <= number; i++)
            //    Console.WriteLine("sugar spoon Nr. "+ i);
        }
    }
}
