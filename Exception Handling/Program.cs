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
            var streamReader = new StreamReader(@"C:\Users\jenish.prajapati\OneDrive - Cotiviti\Desktop\layout.txt");

            try
            {
                dynamic di = numerator / denom;
                Console.WriteLine(di);
                
                var content=streamReader.ReadToEnd();
                //Console.WriteLine(content);

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
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Can't divide by 0");
            }
            finally
            {
                streamReader.Dispose();
            }
            
        }
    }
}
