using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class HotelBookingTests
    {
        [Theory]
        [InlineData(new[] { 1, 3 }, new[] { 2, 6 }, 1, true)]
        [InlineData(new[] { 1, 3, 5 }, new[] { 2, 6, 8 }, 1, false)]
        [InlineData(new[] { 1, 3, 5 }, new[] { 2, 6, 8 }, 2, true)]
        [InlineData(new[] { 1, 1, 1 }, new[] { 2, 3, 8 }, 2, false)]
        [InlineData(new[] { 1, 2, 3 }, new[] { 2, 3, 4 }, 1, true)]
        [InlineData(new[] { 13, 14, 36, 19, 44, 1, 45, 4, 48, 23, 32, 16, 37, 44, 47, 28, 8, 47, 4, 31, 25, 48, 49, 12, 7, 8 }, new[] { 28, 27, 61, 34, 73, 18, 50, 5, 86, 28, 34, 32, 75, 45, 68, 65, 35, 91, 13, 76, 60, 90, 67, 22, 51, 53 }, 23, true)]
        public void Test(int[] arrivals, int[] departures, int availableRooms, bool expectedBookingPossible)
        {
            //Act
            var result = HotelBooking.Run(arrivals, departures, availableRooms);

            //Assert
            result.Should().Be(expectedBookingPossible);

        }
    }
}