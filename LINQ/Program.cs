using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            var lister=new BookRepository().GetBooks();
            var op=new List<Book>();
            foreach (var book in lister)
            {
                if (book.Price<450) 
                { 
                op.Add(book);
                }
            }
            foreach (var book in op)
            {
                Console.WriteLine($"Title:{book.Title} Price:{book.Price}");
            }
            //OR BT USING LINQ
            var opt = lister
                .Where(x => x.Price < 300)
                .OrderBy(x=>x.Price);
            //var opt = lister.Where(x => x.Price < 300).OrderBy(x => x.Price).Select(b => b.Price);

            foreach (var book in opt)
            {
                Console.WriteLine($"Title:{book.Title} Price:{book.Price}");
            }


            //if we only want one single record
            var _singleOutput = lister.SingleOrDefault(x => x.Title == "Harry Potter4");
            Console.WriteLine($"We found :{_singleOutput.Title}");
        }
    }
}
