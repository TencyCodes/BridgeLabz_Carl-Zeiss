using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.VehicleSystem
{
    internal class VehicleSystem
    {
        // Design a Vehicle System where all the vehicles share common behavior but start differently. Demonstrate hierarchical inheritance and overriding 
        //Coding task 
        //Vehicle : method - > startEngine()
        class Vehicle
        {
            public virtual void startEngine()
            {
                Console.WriteLine("Vehicle Engine is Starting");
            }
        }
        class Truck : Vehicle
        {
            public override void startEngine()
            {
                Console.WriteLine("Truck Engine is Starting");
            }
        }
        class Car : Vehicle
        {
            public override void startEngine()
            {
                Console.WriteLine("Car Engine is Starting");
            }
        }
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.startEngine();
            Vehicle v2 = new Truck();
            v2.startEngine();
            Vehicle v3 = new Car();
            v3.startEngine();
        }
    }
}
