using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Circle:IShape
    {
        private float _radius;
        public Circle(float radius )
        {
            this._radius = radius;
        }

        public double calcArea()
        {
            return (3.14 * _radius * _radius);
        }

        public double calcPerimeter()
        {
            return (2 * 3.14 * _radius);
        }
        public void ExtraClassToCheckInterface()
        {
            Console.WriteLine("This is an extra class to check if interface is spoiled");
        }
    }

    public class Rectangle:IShape
    {
        private int _length;
        private int _width;

        public Rectangle(int l,int w)
        {
            _length = l;
            _width = w;
        }

        public double calcArea()
        {
            return _length * _width;
        }

        public double calcPerimeter()
        {
            return (2 * (_length + _width));

        }

    }
}
