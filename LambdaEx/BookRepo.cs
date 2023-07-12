using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEx
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public  class BookRepo
    {
        public List<Book> GetBooks() 
        {
            return new List<Book>
            {
                new Book() { Title="T1",Price=5},
                new Book() {Title="T2",Price=60}
            };
        }
       
    }
}
