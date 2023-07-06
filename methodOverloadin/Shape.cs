using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloadin
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing The Base Class Shape");
        }
    } 
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Cirlce");
        }

    }

    public class Triangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }

    public class Rectangle:Shape
    {
        public  override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
