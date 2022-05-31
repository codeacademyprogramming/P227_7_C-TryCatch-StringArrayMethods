using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
       
        public void AddFuel(int lt)
        {
            if (CurrentFuel + lt <= FuelCapacity)
                CurrentFuel += lt;
            else
            {
                Console.WriteLine("Bak dasdi!");
            }
        }
    }
}
