using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx2
{
    class MyClass : demoInterface
    {
        public void go()
        {
            Console.WriteLine("Method Go Called");
        }

        public void show()
        {
            Console.WriteLine("Method Show Called");
        }
    }
}
