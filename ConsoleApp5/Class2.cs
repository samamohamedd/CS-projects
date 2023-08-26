using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class2
    {
      public int age;
        Class2 getAge (int age)
        {
            this.age = age;
            return this;
        }

    }
    public class Person
    {
        public string name;
        public int age;
        public string address;
        public static int numberOfPeople;

        public static int getTotalNumberOfPeople()
        {
            //age = 0;
            // This method can only access the static member "numberOfPeople"
            return numberOfPeople;
        }
    }
}
