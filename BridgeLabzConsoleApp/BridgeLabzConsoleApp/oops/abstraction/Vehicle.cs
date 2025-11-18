using System;
namespace BridgeLabzConsoleApp.oops.abstraction
{
    public abstract class Vehicle
    {
        protected string _brand;
        private int _year;

        public const int MaxSpeed = 200;
        public Vehicle(string brand, int year)
        {
            _brand = brand;
            _year = year;
            Console.WriteLine("Vehicle constructor is called ");
        }

        public string GetInfo()
        {
            return $"This is a {_brand} vehivle from {_year}";
        }

        public virtual void StartEngine()
        {
            Console.WriteLine($"{_brand} engine is starting...");
        }

        public abstract void move();

        public abstract int CurrentSpeed { get; set; }

        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
}
