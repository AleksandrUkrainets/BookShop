﻿using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; }

        public string Isbn { get; }
        public string Title { get; }

        public string Author { get; }
        public string Description { get; }
        public decimal Price { get; }


        public Book(int id, string isbn, string title, string author, string description, decimal price)
        {
            Id = id;
            Isbn = isbn;
            Title = title;
            Author = author;
            Description = description;
            Price = price;
        }

        internal static bool IsIsbn(string query)
        {
            if (query == null)
            return false;

            query = query.Replace("-", "").Replace(" ", "").ToUpper();

            return Regex.IsMatch(query, @"^ISBN\d{10}(\d{3})?$");

        }
    }
}
