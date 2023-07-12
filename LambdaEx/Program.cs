using System;

namespace LambdaEx
{
    public class Program
    {
        delegate int Func(int a, int b);

        static void Main(string[] args)
        {
            //args => expressions

            Func square = (x, y) => x * y;
            int res = square(5, 5);
            Console.WriteLine(res);

            //We can also use default delegates like Func<> and Action<>
            Func<int,int> lambdaSquare=(x)=>x* x;
            Console.WriteLine($"Square Deligate using Lambda fucntion is :{lambdaSquare(69)}");

            Func<int, int,int> lambdaSquare2 = (x,y) => x * y;
            Console.WriteLine($"Square Deligate using Lambda fucntion is :{lambdaSquare2(6,6)}");
        }
    }
}
