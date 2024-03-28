﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }


        public Engine(int horsePower, double cubicCapaity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapaity;
        }
    }
}