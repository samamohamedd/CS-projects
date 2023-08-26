using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Program
    {
        class manager : Employee
        {
            public string dept;
            public string getDept()
            {
                return dept;
            }

            public void setDept(String dept)
            {
                this.dept = dept;
            }

            public override void calTax()
            {
                double tax = salary * 2;
                Console.WriteLine("Empolyee Tax is " + tax);
            }

        }
         abstract class Employee
        {
            public int ID;
            public string Name;
            public int salary;

            public int getID()
            {
                return ID;
            }

            public void setID()
            {
                if (ID <= 0)
                {
                    Console.WriteLine("Not Allowed");
                }
                else
                {
                    this.ID = ID;
                }
            }

            public string getName()
            {
                return Name;
            }

            public int getSalary()
            {
                return salary;
            }

            public void setSalary(int salary)
            {
                this.salary = salary;
            }

            public void setName(String name)
            {
                this.Name = name;
            }
            abstract public void calTax();
            //{
            //    double tax = salary * 0.05;
            //    Console.WriteLine("Empolyee Tax is " + tax);
            //}

            public Employee(int ID,string name)
            {
                this.ID = ID;
                this.Name = name;
            }

            public Employee(Employee emp)
            {
                ID = emp.ID;
                Name = emp.Name;
                salary = emp.salary;
            }

            public Employee()
            {

            }
        }

        class supervisor : Employee
        {
            public string sec;

            public override void calTax()
            {
                double tax = salary * 2;
                Console.WriteLine("Empolyee Tax is " + tax);
            }
        }


        static void Main(string[] args)
        {
            //Employee e1 = new Employee(101, "sama");
            //e1.ID = 101;
            //e1.salary = 2000;
            //e1.calTax();

            //Employee e2 = new Employee(e1);
          //  e2.calTax();

            manager m1 = new manager();
           // m1.calTax();

            Employee e3 = new manager();
            //e3.salary = 7000;
            //e3.calTax();
            e3 = new supervisor();
            e3.salary = 7000;
            e3.getSalary();
            e3.calTax();

        }
    }
}
