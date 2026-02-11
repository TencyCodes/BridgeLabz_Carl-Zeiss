using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    internal class Problem1
    {
        public class TemperatureSensor
        {
            private double temp;

            public TemperatureSensor(double temperature)
            {
                if (isValidTemp(temperature))
                {
                    temp = temperature;
                }
                else
                {
                    temp = 0;
                }
                
            }
            public void SetTemp(double temper)
            {
                if (isValidTemp(temper))
                {
                    temp = temper;
                }
                else
                {
                    Console.WriteLine("Invalid Temperature");
                }
            }
            public bool isValidTemp(double val)
            {
                if(val>=-50 && val <= 150)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public double GetTemperature()
            {
                return temp;
            }
        }
    }
}
