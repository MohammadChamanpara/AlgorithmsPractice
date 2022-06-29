using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class RepeatedElementTests
    {
        [Theory]
        [InlineData(new int[] { }, -1)]
        [InlineData(new[] { 1, 2, 2 }, 2)]
        [InlineData(new[] { 3, 2, 3, 4 }, 3)]
        [InlineData(new[] { 1, 2, 3, 4 }, -1)]
        public void Test(int[] numbers, int expectedDuplicate)
        {
            //Act
            int output = RepeatedElement.Run(numbers);

            //Assert
            output.Should().Be(expectedDuplicate);
        }
    }
}
