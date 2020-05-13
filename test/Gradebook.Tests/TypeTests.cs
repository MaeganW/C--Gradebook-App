using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test2()
        {
            // arrange
            var book1 = GetBook("New Book");
            var book2 = GetBook("Newer Book");

            Assert.Equal("New Book", book1.Name);
            Assert.Equal("Newer Book", book2.Name);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
