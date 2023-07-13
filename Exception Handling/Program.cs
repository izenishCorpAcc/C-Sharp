using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                dynamic numerator = 29;
                dynamic denom = 0;
            try
            {
                dynamic di = numerator / denom;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Can't divide by 0");
            }

            
        }
    }
}
