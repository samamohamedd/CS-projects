using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution.sqrt();

        }
    }
        public class Solution
        {
            //public static int MySqrt(int x)
            //{

            //   if( nearestSqrt(x) == 1)
            //    {
            //       for( int i = x+1; nearestSqrt(i)*nearestSqrt(i) == 1; i++)
            //        {
            //            if (nearestSqrt(i) != 0)
            //            {

            //            }
            //        }
            //    }



            

            //public static int nearestSqrt (int y)
            //{
            //    for (float i = 1; i < y; i++)
            //    {
            //        if (y % i == 0)
            //        {
            //            if (i * i == y)
            //            {
            //                return (int)i;
            //            }
                        
            //        }
            //    }
            //    return 1;
            //}

            public static int sqrt (int x)
            {
                int right = (x / 2) + 1;
                int left = 0;
                long mid = (right + left) / 2;

                while (left < right)
                {
                  mid = (right  + left) / 2;
                long square = mid * mid;
                    if (square == x)
                    {
                        return (int)mid;
                    }  
                    else if( square < x ){
                        left = (int)mid +1;
                    }
                    else
                    {
                        right = (int)mid -1;
                    }

                }
                return right;

            }
        public static void iluvu()
    {
            int i = 1;
            while (true)
            {

                Console.WriteLine($"I love u {i}");
                i++;
            }
    }
        } 
    }

