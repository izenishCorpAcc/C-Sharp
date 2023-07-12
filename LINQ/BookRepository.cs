using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    public class BookRepository
    {
//        In C#, the main difference between IEnumerable and List is that IEnumerable is an interface, which represents a collection of elements that can be accessed sequentially, while List is a concrete class that implements IEnumerable interface and provides a resizable array of elements.

//IEnumerable allows iterating over a collection of elements and supports querying through LINQ extension methods.It is read-only and cannot be modified once created.List, on the other hand, provides additional functionality for adding, removing, and modifying elements in the collection.
//        In summary, IEnumerable is used for accessing a collection of read-only elements, while List is used for accessing a collection of elements that can be modified.
       public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Harry Potter1",Price=200},
                new Book() {Title="Harry Potter2",Price=300},
                new Book() {Title="Harry Potter3",Price=350},
                new Book() {Title="Harry Potter4",Price=400}


            };

        }
    }
}
