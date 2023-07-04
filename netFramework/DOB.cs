using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    public class DOB
    {
        public DateTime BirthDate { get;private set; }
        public DOB(DateTime d) 
        { 
            this.BirthDate = d;
        }
         
        public int Age
        {
            get
            {
                var timeSpan=DateTime.Today-BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
