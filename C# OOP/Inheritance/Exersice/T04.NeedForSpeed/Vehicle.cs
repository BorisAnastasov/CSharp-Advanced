﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower= horsePower;
            Fuel= fuel;
        }
        public double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption { get ; set; }
        public double Fuel { get; set; }
        public int HorsePower  { get; set; }
        public virtual void Drive(double kilometers)
        {
            if (DefaultFuelConsumption> FuelConsumption)
            {
                this.Fuel -= kilometers * 1.25;
            }
            else
            {
                this.Fuel -= kilometers * FuelConsumption;
            }
            
        }
    }
}
