using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    // Let's create a generic class called Stack<T> that represents a stack data structure.
    public class Stack<T>
    {
        private T[] items;
        private int top;

        public Stack(int capacity)
        {
            items = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new StackOverflowException("Stack is full");
            }

            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[top--];
        }
    }

    // Now, we can use our generic Stack<T> class with different types.
    class Program
    {
        static void Main()
        {
            Stack<int> intStack = new Stack<int>(5);
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            int poppedInt = intStack.Pop();
            Console.WriteLine(poppedInt);  // Output: 30

            Stack<string> stringStack = new Stack<string>(5);
            stringStack.Push("Hello");
            stringStack.Push("World");

            string poppedString = stringStack.Pop();
            Console.WriteLine(poppedString);  // Output: World
        }
    }

}
