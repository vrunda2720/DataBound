using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractclassEx2
{
     abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void work();
    }
    class student:Person
    {
        public override void work()
        {
            Console.WriteLine("It studies...");
        }
    }
    class Employee : Person
    {
        public double salary { get; set; }
        public string Designation { get; set; }
        public override void work()
        {
            Console.WriteLine("It earn...");
        }
    }
    class Manager : Employee
    {
        public  sealed override void work()
        {
            Console.WriteLine("It manages a team...");
        }
    }
    class BranchManager : Manager
    {
    }
    class program
    {
        private static void Main(string[] args)
        {
            Person P = new student();
            P.work();
            P = new Employee();
            P.work();
            P = new BranchManager();
            P.work();
            Console.ReadLine();
        }
    }
}
