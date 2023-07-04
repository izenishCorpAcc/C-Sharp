using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    public class AccessModifiers
    {
        private string _name;

        public void Setter(string _name)
        {
            if (_name == null) throw new ArgumentNullException("_name");

            if(!string.IsNullOrEmpty(_name)) 
                this._name = _name;
        }
        public string Getter()
        {
            return this._name;
        }

        //Using Properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        //autoimpleented properties


        public string Age { get; set; }
        
    }
}
