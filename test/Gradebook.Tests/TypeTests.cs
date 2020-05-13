using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);
            Assert.Equal(3, x);
        }

        private void SetInt(int number)
        {
            number = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            var book1 = GetBook("New Book");
            GetBookSetNameByRef(ref book1, "Updated Book");

            Assert.Equal("Updated Book", book1.Name);
        }

        private void GetBookSetNameByRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("New Book");
            GetBookSetName(book1, "Updated Book");

            Assert.Equal("New Book", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book("");
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("New Book");
            SetName(book1, "Updated Book");

            Assert.Equal("Updated Book", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("New Book");
            var book2 = GetBook("Newer Book");

            Assert.Equal("New Book", book1.Name);
            Assert.Equal("Newer Book", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("New Book");
            var book2 = book1;

            Assert.Equal(book2.Name, book1.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
