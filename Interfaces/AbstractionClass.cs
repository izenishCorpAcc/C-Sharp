using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class AbstractionClass
    {
        public static void PrintShapeDetails(IShape objects)
        {
            Console.WriteLine($"Area using Abstraction:{objects.calcArea()}");
            Console.WriteLine($"Perimeter Using Abstraction:{objects.calcPerimeter()}");
        }
    }
}
