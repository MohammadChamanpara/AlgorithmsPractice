using Algorithms.Integers;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Integers
{
    public class SortDigitsTests
    {
        /*
         *  299 -> 992
         *  123 -> 321
         *  1122786-> 8762211
         */

        [Theory]
        [InlineData(0, 0)]
        [InlineData(10, 10)]
        [InlineData(102, 210)]
        [InlineData(299, 992)]
        [InlineData(123, 321)]
        [InlineData(1122786, 8762211)]
        public void Test(int number, int expectedSorted)
        {
            //Act
            int sorted = SortDigits.Run(number);

            //Assert
            sorted.Should().Be(expectedSorted);
        }
    }
}
