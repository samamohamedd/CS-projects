using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Arrays
{

    public class Solution
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
    }
    internal class Program
    {

        static void printarray(int[] array)
        {
            foreach (int number in array)
                Console.WriteLine(number);
        }

        static void Readarray(int[] array)
        {
            for (int i= 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the numbers");
                array[i] = int.Parse(Console.ReadLine());

            }

        }

        static int SumOfArray (int[] array)
        {
            int sum = 0;
            for (int i= 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        static double AverageOfArray(int[] array)
        {
            int sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double average = (double)sum / (double)array.Length;   
            return (double)average;
        }

        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                
            }
            return max;
        }

        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            return min;
        }

        static int GetIndex(int[] array, int x)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (x == array[i])
                    index = i;
            }
            return index;
        }

        static void Main(string[] args)
        {

            int[] array1 = new int[] { 1, 79 , 10  };

            int[] array2 = new int[3];
            array2[0] = 1;
            array2[1] = 2;
            array2[2] = 3;

            //for (int i =0; i<array1.Length; i++)
            //{
            //    Console.WriteLine(array1[i]);
            //}

            //foreach (int nums in array1)
            //{
            //    Console.WriteLine(nums);
            //}


            //printarray(array1);
            //Readarray(array2);
            //printarray(array2);


            int[] result = new int[3];
            for (int i = 0; i < 3; i++)
            {
                result[i] = array1[i] + array2[i];
                Console.WriteLine("{0} + {1} = {2}", array1[i], array2[i], result[i]);
            }
            

            Console.WriteLine(SumOfArray(array1));
            Console.WriteLine(AverageOfArray(array1));
            Console.WriteLine(Max(array1));
            Console.WriteLine(Min(array1));
            Console.WriteLine(array1.Sum());
            Console.WriteLine(GetIndex(array1 ,1));

            int[] arr = new int[3];

           

           
        }
    }
    }

