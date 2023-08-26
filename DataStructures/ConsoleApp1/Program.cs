using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] array1 = new char[] {'a','b','c'};

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);

            numbers.Insert(0, 3);

        }
    }
}
