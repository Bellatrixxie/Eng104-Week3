using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers
        {
            get => _numPassengers;

            set => _numPassengers = value > _capacity ? _capacity : value < 0 ? 0 : value;
        }

        //public int Position { get; private set; }
        public int Position { get; set; }


        public int Speed { get; init; } // = 10;

        public Vehicle()
        {
            //_capacity = 0;
            //NumPassengers = 0;
            //Position = 0;
            //Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
        }

        public virtual string Move()
        {
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            return times == 1 ? $"Moving along 1 time" : $"Moving along {times} times";
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}
