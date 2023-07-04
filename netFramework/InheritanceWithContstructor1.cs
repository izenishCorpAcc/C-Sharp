using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    internal class InheritanceWithContstructor1
    {
        private string _name;
        public InheritanceWithContstructor1(string ModelNo)
        {
            _name = ModelNo;
            Console.WriteLine($"This is the base class and the MODEL Number is {_name}");
        }
        
    }
}
