﻿using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] _books = new[]
        {
            new Book(1, "Art of programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language"),
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return _books.Where(book => book.Title.Equals(titlePart)).ToArray();
        }
    }
}