using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVehicle
{
    public abstract class Vehicle
    {
        public abstract int Speed();
        public abstract int Wheels();
        public abstract string Name();
    }
}
