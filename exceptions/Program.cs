using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    internal class Program
    {
        static void formatWrong()
        {
            string s = "hdgihsdoig";
            int.Parse(s);
        }
        static void Main(string[] args)
        {

            try
            {

                int n1 = 5, n2 = 0, r = n1/n2;
                Console.WriteLine(r);

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("all good");
            }
            //try
            //{
            //    formatWrong();
            //}
            //catch (Exception ex)
            //{
            //    Console.Error.WriteLine(ex);
            //}

        }
    }
}
