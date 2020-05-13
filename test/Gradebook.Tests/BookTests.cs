using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverage()
        {
            // arrange
            var book = new Book("New Book");
            book.AddGrade(22.3);
            book.AddGrade(92.3);
            book.AddGrade(88.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(22.3, result.LowestGrade, 1);
            Assert.Equal(92.3, result.HighestGrade, 1);
            Assert.Equal(67.6, result.AverageGrade, 1);
        }
    }
}
