using System;

namespace Phase3_OOP_Turial
{
    class Program
    {
        static void Main(string[] args)
        {
            //object

            Employee emp1 = new Accounting();
            emp1.Name = "somsak";
            emp1.Salary = 80000;

            Employee emp2 = new Sale();
            emp2.Name = "jojo";
            emp2.Salary = 70000;

            Console.WriteLine("Name: " + emp1.Name);
            Console.WriteLine("Salary: " + emp1.Salary);

            Console.WriteLine("Name: " + emp2.Name);
            Console.WriteLine("Salary: " + emp2.Salary);

            /*
            Employee emp1 = new Employee("Jirayu", 55000);
            Employee emp2 = new Employee("pompam", 15000);
            Employee emp3 = new Employee("jojo", 9000);*/



            /*
            emp1.set_name("jirayu chomthong");
            emp1.set_salary(150000);

            Console.WriteLine(emp1.get_name());
            Console.WriteLine(emp1.get_salary());



            Employee emp2 = new Employee("pompam", 90000);
            Employee emp3 = new Employee("gogogi", 15000);*/


            Console.ReadKey();
        }
    }
}