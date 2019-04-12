using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalEx1
{
    interface IAnimal
    {
        void speak();
        int legs();
        void printNumberOfLegs();
        void printNumberofEyes(int e);
    }

    class Dog:IAnimal
    {
        public void speak()
        {
            Console.WriteLine("Dog is speaking bhau");
        }
        public int legs()
        {
            return 4;
        }

        public void printNumberOfLegs()
        {
            Console.WriteLine("Dog has number of legs 4");
        }

        public void printNumberofEyes(int e)
        {
            Console.WriteLine("Number of eyes Dog " + e.ToString());
        }
    }
    class Octopus : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("Octopus is speaking trut");
        }
        public int legs()
        {
            return 8;
        }

        public void printNumberOfLegs()
        {
            Console.WriteLine("Octopus has number of legs 8");
        }

        public void printNumberofEyes(int e)
        {
            Console.WriteLine("Number of eyes Octopus" + e.ToString());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog D = new Dog();
            D.speak();
            int legsofDog = D.legs();
            Console.WriteLine("Dogs -- " + legsofDog);
            D.printNumberOfLegs();
            D.printNumberofEyes(3);


            Octopus O = new Octopus();
            O.speak();
            int legsofOctopus = O.legs();
            Console.WriteLine("Octopus -- " + legsofOctopus);
            O.printNumberOfLegs();
            O.printNumberofEyes(4);



            Console.ReadLine();
        }
    }
}
