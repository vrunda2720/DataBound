using System;



 public interface IAnimal
  {
    // int GetNumberOfLegs();
      public void Getlegs(int number);
      public void speak();
  }

 class Dog : IAnimal
    {
    public void Getlegs(int number)
    {
        //throw new NotImplementedException();
    }

    string IAnimal.speak()
    {
        throw new NotImplementedException();
    }
}
 class Octopus : IAnimal
    {
    public void Getlegs(int number)
    {
        throw new NotImplementedException();
    }

    string IAnimal.speak()
    {
        throw new NotImplementedException();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Dog d = new Dog();

    }
}


