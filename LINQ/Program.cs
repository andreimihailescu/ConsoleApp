using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();

            var books = bookShelf.GetBooks();

            var query = from b in books
                        group b.Title by b.Genre into g
                        select new { Genre = g.Key, Titles = g.ToList() };

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
