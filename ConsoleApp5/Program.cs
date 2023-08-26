using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     public class indexer
    {
        public int[] array1 = new int[10];
        public int this[int i]
        {
            get { return array1[i]; }
            set { array1[i] = value; }
        } 


    }
    public class class1
    {
        public int value;

        public class1(int i){
            this.value = i;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //indexer indexer = new indexer();
            //indexer[5] = 99;
            //Console.WriteLine($"the value is {indexer[5]}");

            bool z = true;
            int i = 5;

            class1 first = new class1(7);
            class1 second = new class1(5);
            second = first;
            first.value = 4;
            // second.value = 2;
            Console.WriteLine(second.value);
            Person.numberOfPeople = 4;



            public int[] array1 = new int[10];
        public int this[int i]
        {
            get { return array1[i]; }
            set { array1[i] = value; }
        }

    
        }
    }

