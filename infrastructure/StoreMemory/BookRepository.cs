using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] _books = new[]
        {
            new Book(1, "ISBN 0321751043", "Art of Programming", "Donald E. Knuth", "Art of Programming of Donald E. Knuth", 25m),
            new Book(2, "ISBN 1484255801","Refactoring", "Lisa Bohm", "Refactoring of Lisa Bohm", 32m),
            new Book(3, "ISBN 0131103628","C Programming Language", "Brian W. Kernighan", "C Programming Language of Brian W. Kernighan", 7.24m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return _books.Where(book => book.Isbn == isbn).ToArray();
        }


        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return _books.Where(book => book.Title.Contains(titleOrAuthor) || book.Author.Contains(titleOrAuthor)).ToArray();
        }

        public Book GetById(int id)
        {
            return _books.Single(Book => Book.Id.Equals(id));//my version
        }
    }
}
