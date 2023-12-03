using System;

namespace Abstraction
{
    //abstract keyword k sath use hoga
    //agar class k andar ik bhi abstract method hoga to phir hamain class ko bhi abstract banana hoga
    //abstract class person
    //{
    //    public int Id;
    //    public string name;
    //    public string phoneNumber;
    //    public string address;

    //    public abstract void printDetails();

    //}
    class employee
    {
        private int id;
        private string name;
        private string phoneNumber;
        private int salary;
        private double grossSalary;
        private int netSalary;

        public employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        private void showDetails()
        {
            if (this.salary >= 30000)
            {
                grossSalary = this.salary - this.salary * 0.1;
                Console.WriteLine("Your Id is {0}", id);
                Console.WriteLine("Your Name is {0}", name);
                Console.WriteLine("Your net Salary is {0}", grossSalary);
            }
            else
            {
                Console.WriteLine("Your Id is {0}", id);
                Console.WriteLine("Your Name is {0}", name);
                Console.WriteLine("Your net Salary is {0}", this.salary);
            }
        }
        public void showEmployeeDetails()
        {
            this.showDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee adil = new employee(12, "Adil", 400000);
            adil.showEmployeeDetails();
            Console.ReadLine();
        }
    }
}
