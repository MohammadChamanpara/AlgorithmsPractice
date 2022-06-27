using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class GasStationsTests
    {
        /*
         * Gas  1 2
         * Cost 2 1
         * 
         */

        [Theory]
        [InlineData(new int[] { }, new int[] { }, -1)]
        [InlineData(new[] { 1, 2 }, new[] { 2, 1 }, 1)]
        public void Test(int[] Gases, int[] Costs, int expectedStartPosition)
        {
            //Act
            int startPsition = GasStations.Run(Gases, Costs);

            //Assert
            startPsition.Should().Be(expectedStartPosition);
        }
    }
}
