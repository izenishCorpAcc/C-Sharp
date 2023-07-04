using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    internal class ConstructorDemo
    {
        public int id;
        public string name;

        public ConstructorDemo(int Id,string Name)
        {
            this.id = Id;
            this.name = Name;            
        }
    }
}
