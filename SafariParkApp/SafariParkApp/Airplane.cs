using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        private string? _airline;

        public int Altitude { get; private set; } = 0;

        public Airplane(int capacity) : base(capacity)
        {
        }
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }
        // Ascend() and Descend() are only ways to change Altitude, since its setter is private.

        public void Ascend(int distance)
        {
            Altitude += distance;
        }
        public void Descend(int distance)
        {
            Altitude -= distance;
        }
        public override string Move()
        {
            Position+= 100;
            return $"{base.Move()} at an altitude of {Altitude} metres";
        }
        public override string Move(int times)
        {
            Position += times *100;
            return $"Moving along {times} times at an altitude of {Altitude} metres";
        }
        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: 200 passengers: 150 speed: 100 position: {Position} altitude: {Altitude}";
        }
    }
}


