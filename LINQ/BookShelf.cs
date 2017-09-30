using System.Collections.Generic;

namespace LINQ
{
    public class BookShelf
    {
        private IEnumerable<Book> Books = new Book[] {
                new Book() { Title = "C# programming", Genre = "Educational", Price = 5 },
                new Book() { Title = "Java programming", Genre = "Educational", Price = 4 },
                new Book() { Title = "Titanic", Genre = "Romance", Price = 3 },
                new Book() { Title = "Grown Ups", Genre = "Comedy", Price = 3 }
            };

        public IEnumerable<Book> GetBooks()
        {
            return Books;
        }
    }
}
