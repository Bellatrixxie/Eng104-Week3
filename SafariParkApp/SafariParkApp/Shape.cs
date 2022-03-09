using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp

    // Abstract and no abstract classes can have both concrete and abstract methods.
    // Concrete classes cannot have abstract methods
    // Abstract methods MUST be implemented in their derived classes.
{
    public abstract class Shape
    {
        // An abstract method has a method signature but NO method body.
        //public abstract int CalculateArea();

        public int CalculateArea()
        {
            return _width * _height;
        }
    }
    // Derived classes must implement abstract methods from their base class
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public override int CalculateArea()
        {
            throw new NotImplementedException();
        }

        // Eg, Nish used abstract class for API app for push, post, delete, get requests.
        // Whatever the request, you needed an API token.

    }
}

