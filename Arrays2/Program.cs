using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Print2DArray (int[,] array)
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int r = 0; r < array.GetLength (1); r++)
                {
                    Console.Write (array [i, r] +" ");
                }
                Console.WriteLine ();
            }

            //Printing the array as a vector

            foreach (int i in array)
            {
                Console.WriteLine (i);
            }
        }

        static void Read2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int r = 0; r < array.GetLength(1); r++)
                {
                    Console.WriteLine ("please enter element [ {0} , {1} ]",i,r);
                    array [i,r] = int.Parse(Console.ReadLine());
                }
            }
        }   
            static void Main(string[] args)
        {
            int[,] array1 = new int[2,2];
            
            Read2DArray(array1);
            Print2DArray(array1);
        }

    }
}
