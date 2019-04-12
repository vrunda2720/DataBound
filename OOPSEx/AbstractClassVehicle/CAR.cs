using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVehicle
{
    public class CAR : Vehicle
    {
        public override string Name()
        {
            return "Baleno";
        }

        public override int Speed()
        {
            return 120;
        }

        public override int Wheels()
        {
            return 4;
        }
    }
}
