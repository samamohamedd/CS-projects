using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oop_stuff
{
   
    class Bird
    {

    }

    // Creating a sealed class
    sealed class Test : Bird
    {
    }

    // Inheriting the Sealed Class
    class Example : Test
    {
    }

    // Driver Class
 

    interface Iinterface
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            vector1 a = new vector1(10, 5);
            vector1 b = new vector1(6, 2);
            vector1 c = a - b;

            Console.WriteLine(c.x); // prints 4
            Console.WriteLine(c.y); // prints 6

        }
    }

    //public class Vector2
    //{
    //    public float X { get; set; }
    //    public float Y { get; set; }

    //    public Vector2(float x, float y) //costructor
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public static Vector2 operator +(Vector2 a, Vector2 b)
    //    {
    //        return new Vector2(a.X + b.X, a.Y + b.Y);
    //    }
    //}

    public class vector1
    {

        public float x { get; set; }
        public float y { get; set; }

        public vector1(float x,float y) //costructor
        {
            this.x = x;
            this.y = y;
        }

        public static vector1 operator -(vector1 a,vector1 b)
        {
            return new vector1(a.x - b.x, a.y - b.y);
        }

        
    }
}
