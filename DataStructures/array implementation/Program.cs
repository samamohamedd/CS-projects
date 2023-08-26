using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_implementation
{
    class myArray
    {
        public int length;
        public object[] data;

        public myArray()
        {
            this.length = 0;
            this.data = new object[1];
        }

        public object get(int index) { return this.data[index]; }
        public void set(int index, object value)
        {
            this.data[index] = value;
        }

        public object[] push(object item)
        {
            if (this.data.Length == this.length)
            {
                object[] temp = new object[this.length];
                Array.Copy(this.data, temp, this.length);
                this.data = new object[length+1];
                Array.Copy(temp , this.data , length);
            }
            this.data [this.length] = item;
            this.length++;
            return this.data;
        }

        public object pop()
        {
            Object poped = data[this.length - 1];
            this.data[length-1] = null;
            this.length--;
            return poped;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myArray Array1 = new myArray();
            Array1.push("hi");
            Array1.push("!");
           Console.WriteLine(Array1.get(1));
          
        }
    }
}
