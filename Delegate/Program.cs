using System;

namespace DelegateExample
{
    public class Program
    {
        delegate int DelegateFunction(int a, int b);

        int Add(int a, int b)
        {
            return a + b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            DelegateFunction adder = program.Add;
            DelegateFunction multiplier = program.Multiply;

            int res = adder(5, 6);
            Console.WriteLine(res);  // Output: 11

            int res2 = multiplier(4, 9);
            Console.WriteLine(res2);  // Output: 36

            // Combining two delegates
            DelegateFunction addMultiply = adder + multiplier;
            int res3 = addMultiply(9, 9);
            Console.WriteLine(res3);  // Output: 90
        }
    }
}
