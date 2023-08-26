using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 16, y = 35,z;
            z = x & y;
            Console.WriteLine("x AND y = " + z);

            z = x | y;
            Console.WriteLine("x OR y = "+z);

            z = x ^ y;
            Console.WriteLine("x XOR y = " + z);

            z = x << 2;
            Console.WriteLine("x left shift by 2 is " + z);

            z = y >> 2;
            Console.WriteLine("y right shift by 2 is "+ z);



            //int a=3 ,b = 4 ,c = 5 ,n = 0;
            //n = a-- + b * ++c;
            //Console.WriteLine("a-- + b * ++c = " + n);

            //a = 3;b = 4; c = 5;n = 0;
            //n = (a++) + (b / (--c));
            //Console.WriteLine("a++ + b / --c = " + n);

            //a = 3; b = 4; c = 5;
            //bool m = a + b * --c > c / a;
            //Console.WriteLine("a + b * --c > c / a is " + m);





            //Console.WriteLine("Enter the raduis");
            //double raduis = double.Parse(Console.ReadLine()),area;
            //const double PI = 3.14;

            //area = PI * raduis * raduis;

            //Console.WriteLine(area);




            //int x = 10, y = 2;
            //bool z = false;

            //z = (x > y || x == y);
            //Console.WriteLine(z);

            //z = (x >= y && x == y);
            //Console.WriteLine(z);

            //z = (x < y || x != y);
            //Console.WriteLine(z);

            //z = !(x <= y);
            //Console.WriteLine(z);










            //Console.WriteLine("Please enter first number");
            //int firstnum = int.Parse (Console.ReadLine());

            //Console.WriteLine("please enter secound nember");
            //int secnum = int.Parse(Console.ReadLine());

            //int result = firstnum + secnum;
            //Console.WriteLine("first number + secound number = " + result);

            //result = firstnum - secnum;
            //Console.WriteLine ("first number - secound number = " + result);

            //result = firstnum * secnum;
            //Console.WriteLine("first number * secound number = " + result);

            //result = firstnum / secnum;
            //Console.WriteLine("first number / secound number = " + result);

            //int a = 3 , b = 6 ,c = 0 ;
            //c = (a++) + (b--) + a + b;
            //Console.WriteLine(c);

            //c = (a++) + (++b) + a + b;
            //Console.WriteLine(c);

            //c = (a++) + (--b) + a + b;
            //Console.WriteLine(c);

            //c = (--a) + (b++) + a + b;
            //Console.WriteLine(c);

            //c = (--a) + (++b) + a + b;
            //Console.WriteLine(c);



        }
    }
}
