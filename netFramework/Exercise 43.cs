using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    internal class Exercise_43
    {
        
        public static void Check(int n) => Console.WriteLine((n > 0 && n < 11) ? "Valid" : "Invalid");

        public static void maxnum(int x, int y) => Console.WriteLine("The MAX number is: " +System.Math.Max(x, y));

        public static void speedLimit(int speedlimit,int currentspeed)
        {
            int x = currentspeed - speedlimit;
            int count = 0;
            for(int i = 0; i < x; i =i+ 5)
            {
                count++;
                if (count <= 12)
                {
                    Console.WriteLine("Demerited");
                }
                else {
                    Console.WriteLine("Lisence Canceled");
                    break;
                        } 
            }


        }
    }
}
