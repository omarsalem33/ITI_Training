using System;
using System.Collections.Generic;

namespace Day8
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>; 
            books. Add(new Book("5444" , "BookTitle" ,new string[] {"mohamed"} ,new DateTime (2022,3,3) ,new decimal 2.51));
            books. Add(new Book("5413" , "BookTitle2" ,new string[] {"ahmed"} ,new DateTime (2001,4,3) ,new decimal 150.4));

            LibraryEngine.GatValue GetISBN = delegate (Book book) { return book.ISBN};
            LibraryEngine.ProcessBooks(books,BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(books,   GetISBN);
            LibraryEngine.ProcessBooks(books,(Book book) => { return book.PublicationDate.ToString; });

            


              
        }
    }
}
