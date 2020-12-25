using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] _books = new[]
        {
            new Book(1, "ISBN 0321751043", "Art of Programming", "Donald E. Knuth"),
            new Book(2, "ISBN 1484255801","Refactoring", "Lisa Bohm"),
            new Book(3, "ISBN 0131103628","C Programming Language", "Brian W. Kernighan"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return _books.Where(book => book.Isbn == isbn).ToArray();
        }

        //public Book[] GetAllByTitle(string titlePart)
        //{
        //    return _books.Where(book => book.Title.Contains(titlePart)).ToArray();
        //}

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return _books.Where(book => book.Title.Contains(titleOrAuthor) || book.Author.Contains(titleOrAuthor)).ToArray();
        }
    }
}
