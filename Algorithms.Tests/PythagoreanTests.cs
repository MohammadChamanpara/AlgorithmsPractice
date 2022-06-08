using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class PythagoreanTests
    {
        [Theory]
        [InlineData(new[] { 3, 4, 5 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 1 }, true)]
        [InlineData(new[] { 5, 12, 13, 5 }, true)]
        [InlineData(new[] { 5, 12, 14 }, false)]
        [InlineData(new[] { 39, 80, 100, 89 }, true)]
        public void PythagoreanTest(int[] numbers, bool expectedResult)
        {
            //Act
            bool result = Pythagorean.HasPythagoreanTriples(numbers);

            //Assert
            result.Should().Be(expectedResult);

        }

    }
}