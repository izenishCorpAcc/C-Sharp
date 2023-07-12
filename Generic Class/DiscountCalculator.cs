using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    public class DiscountCalculator<T> where T:Product
    {
        public float Calc(T product)
        {
            return product.Price;
        }
    }
}
