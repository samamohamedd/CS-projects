using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
        }
        public bool IsPalindrome(int x)
        {
            
            string z = x.ToString();
            string[] notReversed = z.Split(',');
            string[] reversed = z.Split(',');
            reversed.Reverse();
            int count = 0;

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
