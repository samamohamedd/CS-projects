using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public bool IsPalindrome(float x)
        {
            float myFloat = 121f;
            byte[] myArray = BitConverter.GetBytes(myFloat);
            Array.Reverse(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0:X2} ", myArray[i]);
            }
        }

        public bool IsPalindrome2(float x)
        {
            string str1 = x.ToString();
            char[] reversed = str1.ToCharArray();
            char[] notReversed = str1.ToCharArray();
            Array.Reverse(reversed);
            float count = 0;

            for (int i = 0; i < reversed.Length; i++)
            {
                if (reversed[i] == notReversed[i])
                {
                    count++;
                }


            }
            if (count == reversed.Length)
            {
                return true;
            }
            return false;
        }
    }
}

