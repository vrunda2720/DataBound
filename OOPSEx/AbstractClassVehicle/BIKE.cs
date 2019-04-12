using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVehicle
{
    public class BIKE : Vehicle
    {
        public override string Name()
        {
            return "Avenger";
        }

        public override int Speed()
        { 
            return 100;
        }

        public override int Wheels()
        {
            return 2;
        }
    }
}
