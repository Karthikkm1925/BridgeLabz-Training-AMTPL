using BridgeLabzConsoleApp.oops.abstraction;
using System;

namespace BridgeLabzConsoleApp.oops.abstraction
{
     
    public class AbstractionDemo
    {
        public static void Main(string[] args)
        {
            Car car = new Car("BMW", 2025);
            car.CurrentSpeed = 100;
            car.StartEngine();
            car.move();
            Console.WriteLine($"Max Speed of Car is {Vehicle.MaxSpeed} and current speed is {car.CurrentSpeed}");
            Console.ReadLine();
        }
    }
}
