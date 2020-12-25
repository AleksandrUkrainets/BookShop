using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_RetutnFalse()
        {
            bool actual = Book.IsIsbn(null);
            Assert.False(actual);

        }

        [Fact]
        public void IsIsbn_WithSpace_RetutnFalse()
        {
            bool actual = Book.IsIsbn("   ");
            Assert.False(actual);

        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_RetutnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");
            Assert.False(actual);

        }

        [Fact]
        public void IsIsbn_WithIsbn10_RetutnTrue()
        {
            bool actual = Book.IsIsbn("IsbN 123-456-789 0 ");
            Assert.True(actual);

        }

        [Fact]
        public void IsIsbn_WithIsbn13_RetutnTrue()
        {
            bool actual = Book.IsIsbn("IsbN 123-456-789 0123 ");
            Assert.True(actual);

        }

        [Fact]
        public void IsIsbn_WithTrashString_RetutnFalse()
        {
            bool actual = Book.IsIsbn("wwwIsbN 123-456-789 0yyyy ");
            Assert.False(actual);

        }
    }
}
