using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    internal class @string
    {
         public static void StringOperations()
        {
            var fullName = "    Jenish Prajapati   ";
            Console.WriteLine(fullName);
            Console.WriteLine($"Trim:{fullName.Trim()}");
            Console.WriteLine($"ToUpper {fullName.Trim().ToUpper()}");
            Console.WriteLine($"ToLower {fullName.Trim().ToLower()}");


            var index=fullName.Trim().IndexOf(' ');
            var firstName=fullName.Trim().Substring(0,index);
            var lastName=fullName.Trim().Substring(index+1);
            Console.WriteLine($"First Name:"+firstName);
            Console.WriteLine($"Last Name:" + lastName);

            var names=fullName.Trim().Split(' ');
            Console.WriteLine($"First Name:" + names[0]);
            Console.WriteLine($"Last Name:" + names[1]);

            if (String.IsNullOrWhiteSpace(null)) {
                Console.WriteLine("Invalid");
                    }

        }
    }
}
