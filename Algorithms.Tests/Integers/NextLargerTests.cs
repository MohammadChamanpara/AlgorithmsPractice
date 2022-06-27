using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Integers
{
    public class NextLargerTests
    {
        /*
         * N = 55, Answer : 56
         * N = 1765 ,Answer: 1767
         * N = 44432, Answer: 45010
         * 
         * n+1   44433
         * pos:3 
         * n+=1000 45433
         * n/=1000  45
         * n*=1000  45000
         * pos-=2 -> 1
         * n+=10 45010
         * 
         * 
         */

        [Theory]
        [InlineData(55,56)]
        [InlineData(1765,1767)]
        [InlineData(44432,45010)]
        public void Test(int number, int expectedLarger)
        {
            //Act
            int larger = NextLarger.Run(number);

            //Assert
            larger.Should().Be(expectedLarger);
        }
    }
}
