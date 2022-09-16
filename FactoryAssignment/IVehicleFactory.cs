﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment
{
    internal interface IVehicleFactory
    {
        ICarEngine installEngine(string type);
        ICarLight installLight(string type);
    }
}
