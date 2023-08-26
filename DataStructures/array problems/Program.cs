using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace array_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string name = "ahmed";
            //  string reversedString = reverseString(name);
            // Console.WriteLine(reverseString("ahmed"));
            //  Console.WriteLine(betterReverseString(""));
            int[] x = { 1, 4, 7 };
            int[] y = { -2 , -1};
            Console.WriteLine(MaxSubArray(y));
        //    int[] z = mergeSortedArrays(x, y);
        //    foreach (int i in z)
          //  {
           //     Console.WriteLine(i);
            //}
        }

        public static string reverseString (string inputtext)
        {
            char[] original = inputtext.ToCharArray();
            Array.Reverse(original);
            string reversed = new string(original);
            // Console.WriteLine( reversed );
            return reversed;
        }

        public static string betterReverseString (string input)
        {
            
            if(string.IsNullOrEmpty(input) || input.Length < 2) //check input
            {
                return "not good";
            }
            else
            {
                char[] reversed = input.ToCharArray();
                Array.Reverse(reversed);
                string reversedString = new string(reversed);
                return reversedString;
            }

        }
        //public static int[] mergeSortedArrays(int[] arr1 , int[] arr2)
        //{
        //    int[] BigArray = new int[arr1.Length+arr2.Length];
        //    int k = 0,i=0,j=0;
        //    for (int i = 0; i < arr1.Length; k++)
        //    {
        //        for(int j = 0; j < arr2.Length; j++)
        //        {
        //            if (arr1[i] < arr2[j])
        //            {
        //                BigArray[k] = arr1[i++];
        //                break;
        //            }
        //            else
        //            {
        //                BigArray[k] = arr2[j];
        //                break;
        //            }
                    
        //        }
        //        k++;

        //    }
        //    return BigArray;
        //}
        
        public static int MaxSubArray(int[] nums) //[5,4,-1,7,8]
        {
            float maxTillNow = 0;
            float MaxSubArray = 0;
            float sum = 0;
            if (nums != null && nums.Length != 1) { 
            for(int j = 0; j < nums.Length; j++) {
                sum = 0;
                for (int i = j; i < nums.Length; i++)
                {
                    sum = sum + nums[i];
                    if (sum > maxTillNow)
                        maxTillNow = sum;
                }    
                
                if (maxTillNow > MaxSubArray)
                    MaxSubArray = maxTillNow;
            }
            } else if (nums.Length == 1)
            {
                return nums[0];
            } 
            if (MaxSubArray == 0)
            {
                float max = nums.Max();
                return (int)max;
            }
            return (int)MaxSubArray;

        }

            //foreach (int num in nums)
            //{
            //    sum = sum + num;
            //}
           
    }
}
