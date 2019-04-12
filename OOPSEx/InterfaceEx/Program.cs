using InterfaceEx;
using System;

//Simple Interface


//A class implements interface.
class Myclass:interface1
{
    public void show()
    {
        Console.WriteLine("welcome to the show!!!");
    }

    //main method
    public static void Main(string[] args)
    {
        //creating object
        Myclass obj1 = new Myclass();
        obj1.show();
    }
}
