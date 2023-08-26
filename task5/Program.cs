using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnum, secnum, result;
            char operation;

            Console.WriteLine("Please enter the first number");
            firstnum = int.Parse( Console.ReadLine() );

            Console.WriteLine("Please enter the secound number");
            secnum = int.Parse( Console.ReadLine() );

            Console.WriteLine("Please enter the operation");
            operation = char.Parse (Console.ReadLine());

            switch (operation)
            {
                case '+':
                result = firstnum + secnum;
                Console.WriteLine (result);
                    break;

                case '-':
                    result = firstnum - secnum;
                    Console.WriteLine(result);
                    break ;
                
                case '*':
                    result = firstnum * secnum;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = firstnum / secnum;
                    Console.WriteLine(result);
                    break;

            }
           
               
           
            
                
         




















            //double balance, callduration, pricepermin, requiredbalance;

            //Console.WriteLine("Please enter the balance");
            //balance = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the call duration");
            //callduration = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the price per minute");
            //pricepermin = double.Parse(Console.ReadLine());

            //requiredbalance = callduration * pricepermin;

            //bool callallowance = (requiredbalance <=balance)? true:false;
            //switch (callallowance)
            //{
            //    case true:
            //        Console.WriteLine("user is allwed to call");
            //        break;
            //    case false:
            //        Console.WriteLine("user is not allawed to call");
            //        break ;



        }










            //bool closed = false;
            //bool broken = true;

            //if (closed)
            //    Console.WriteLine("bulb is closed");

            //else if (broken)
            //    Console.WriteLine("bulb is broken");

            //else Console.WriteLine("bulb is open");
                    
            }
                
            
        }
    

