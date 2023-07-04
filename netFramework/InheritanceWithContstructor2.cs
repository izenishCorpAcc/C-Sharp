using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    internal class InheritanceWithContstructor2:InheritanceWithContstructor1
    {
        public InheritanceWithContstructor2(string PassingForward):base(PassingForward)
        {
            Console.WriteLine($"This is the CHILD CLASS and the value {PassingForward} is passed to the Constructor of the Parent class");


        }

    }
}
