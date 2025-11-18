using System;
namespace BridgeLabzConsoleApp.oops.abstraction
{
    public class Car : Vehicle
    {
        private int _speed;

        public Car(string brand, int year) : base(brand, year)
        {
            Console.WriteLine("Car constructor is called...");
        }

        public override void move()
        {
            Console.WriteLine($"{_brand} car is driving on the road");
        }

        public override int CurrentSpeed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public override void StartEngine()
        {
            base.StartEngine();
            Console.WriteLine("Engine started...");
        }
    }
}
