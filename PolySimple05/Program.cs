using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySimple05 // Abstract classes allow us to enforce method
                       // implementation in derived classes
{
    abstract class Vehicle
    {
        public abstract void Start();
    }

    class Car: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting.....");
        }
    }

    class Bike: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            Vehicle v2 = new Bike();

            v1.Start(); // Output: Car is starting......
            v2.Start(); // Output: Bike is starting......
        }
    }
}
