using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                bool f = false;
                string z = x.ToString();
                string notReversed = z;
                string reversed = z;
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
}
