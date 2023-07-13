using System;
using System.Collections.Generic;
using System.IO;
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
            dynamic denom = 10;


           StreamReader streamReader = null;

            try
            {

                streamReader = new StreamReader(@"C:\Users\jenish.prajapati\OneDrive - Cotiviti\Desktop\layout.txt");
                //dynamic di = numerator / denom;
                //dynamic di = numerator / denom;

                //Console.WriteLine(di);

                var content = streamReader.ReadToEnd();
                Console.WriteLine(content);
                //We can alternatively use using so that the compile will generate a finally clause under the hood
                //using(var streamReader=new StreamReader(@"C:\Users\jenish.prajapati\OneDrive - Cotiviti\Desktop\layout.txt")) 
                //{
                //    var content= streamReader.ReadToEnd();
                //}

            }
            catch (DivideByZeroException ex)    //order of catch statements maters
            {
                Console.WriteLine(ex);
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex);
            }

            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("SORRY AND EXCEPTION OCCOURED!");
                //Console.WriteLine("Can't divide by 0");
            }
            finally
            {
                streamReader.Dispose();
            }

        }
    }
}
