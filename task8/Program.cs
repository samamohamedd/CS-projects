using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the side length");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Add( x , y );
        }

         public static int Add(int x , int y)
        {
            return x + y;
        }
        public static double Add(double x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
