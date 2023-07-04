using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    public class Indexer
    {
        public Dictionary<string,string> _keyValuePairs = new Dictionary<string,string>();

        public string this[string key]
        {
            get { return _keyValuePairs[key]; }
            set { _keyValuePairs[key]=value;}
        }
    }
}
