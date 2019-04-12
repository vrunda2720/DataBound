using System;


namespace abstractclass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // abstract class 'G'
    public abstract class G
    {
        // abstract method 'gfg1()'
        public abstract void gfg1();

        public void speak()
        {
            Console.WriteLine("hi");
        }
    }

    //child class 'G1"
    public class G1 : G
    {

        //abstract Method 'gfg1()'
        public override void gfg1()
        {
            //throw new NotImplementedException();
            Console.WriteLine("class name is G1");
        }
    }
    //child class 'G2"
    public class G2 : G
    {

        //abstract Method 'gfg1()'
        public override void gfg1()
        {
            //throw new NotImplementedException();
            Console.WriteLine("class name is G2");
        }
    }
    //derived class
    public class main_method
    {
        //main method
        public static void Main()
        {
            G obj;
            obj = new G1();
            obj.gfg1();
            obj.speak();
            obj = new G2();
            obj.gfg1();

            Console.ReadLine();



        }

    }

}