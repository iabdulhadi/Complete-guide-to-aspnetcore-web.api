using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }

        //navigation properties for the book
        public int BookId { get; set; }
        public Book Book { get; set; }

        //navigation properties for Author
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
