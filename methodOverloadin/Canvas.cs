using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloadin
{
    public class Canvas
    {
        public void Depict(List<Shape> objects)
        {
            foreach(Shape shape in objects)
            {
                shape.Draw();
            }
        }
    }
}
