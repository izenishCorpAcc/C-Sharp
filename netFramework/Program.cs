using netFramework.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace netFramework
{
    public class Test {
        public string FirstName;
        public string LastName;

        public void Introduce() { 
        Console.WriteLine("HI i am {0} {1} ",FirstName,LastName);
            var names = new string[] { "Jenish", "Kajal", "Zeal" };
            var joined = string.Join("\n ,", names);
            Console.WriteLine(joined);
        }
    }
    public class Person
    {
        public string Name;
        public List<Order> Orders;    //List of Order Type objects
        public DateTime Dob { get; set; }
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string input)
        {
            var person= new Person();
            person.Name = input;
            return person;
        }

        //Constructor

        public Person()
        {
            Orders = new List<Order>();  //To avoid nullable error , rule of thumb 
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Test obj1 = new Test();
            //   obj1.FirstName = "Jenish";
            //   obj1.LastName = "Prajapati";
            //   obj1.Introduce();

            //   Exercise_43.Check(2);
            //   Exercise_43.maxnum(289, 99);
            //   Exercise_43.speedLimit(50, 160);

            //   @string.StringOperations();
            //   //Exercise_68.assignment();
            //   if (Exercise_68.Assignment())
            //   {
            //       Console.WriteLine("Consecutive");
            //   }
            //   else
            //   {
            //       Console.WriteLine("Not Consequtive");
            //   }


            //Directory
            //   Exercise_68.Assignment2();
            //   Dir.DirectoryList();

            //var person=new Person();
            //person.Name = "Jenish";
            //person.Introduce(person.Name);


            //Object Initializer
            var P2 = new Person { Name = "Rebecca" };
            Console.WriteLine(P2.Name);


            Person p1 = Person.Parse("Pakhe");
            p1.Introduce("Khepa");

            //Constructor
            var constructorClass = new ConstructorDemo(1, "BillGates");
            Console.WriteLine($" SN:{constructorClass.id} Name:{constructorClass.name}");

            //Calc
           Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3,4,5,6,7,8,9));
            Console.WriteLine(calculator.Add(new int[] { 1, 2,3,4,5,6,7,8,9 }));

            //AccessModifiers
            AccessModifiers A=new AccessModifiers();
            A.Setter("Pama");
            Console.WriteLine(A.Getter());

            //DOB using autoimplemented properties
            var dob=new DOB(new DateTime(1999,7,2));
            //dob.BirthDate = new DateTime(1999, 7, 2);  //wont work because the set property is set PRIVATE
            Console.WriteLine(dob.Age);


            //INDEXER
            var cookie = new Indexer();
            cookie["name"] = "Genesis";
            cookie["age"] = "23";


            Console.WriteLine($"Key value Pair's name:{cookie["name"]} and age:{cookie["age"]}");

            //StopWatch
            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            Console.WriteLine("Stopwatch started.");
            stopwatch.StartStopwatch();

            // Simulate some time-consuming operation
            Console.WriteLine("Performing operation...");
            Thread.Sleep(6000); // Simulating a 6-second operation

            // Stop the stopwatch
            TimeSpan duration = stopwatch.Stop();
            Console.WriteLine("Stopwatch stopped. Duration: " + duration);

            Console.ReadLine();
        }

    }
}
