using Algorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class LargestRectangleTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] matrix, int expectedSize)
        {
            //Act
            int size = LargestRectangle.Run(matrix);

            //Assert
            size.Should().Be(expectedSize);
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new [,]    // Input Matrix
                {
                    { 0,0,0,0 },
                    { 0,0,0,0 },
                    { 0,0,0,0 },
                    { 0,0,0,0 }
                },
                0   //Expected Rectangle Size
            },
            
            new object[]
            {
                new [,]    // Input Matrix
                {
                    { 0,1,1,0 },
                    { 1,1,1,1 },
                    { 1,1,1,1 },
                    { 1,1,0,0 }
                },
                8   //Expected Rectangle Size
            },

            new object[]
            {
                new [,]    // Input Matrix
                {
                    { 0,1,0,0 },
                    { 0,1,1,1 },
                    { 1,1,1,1 },
                    { 1,1,0,0 }
                },
                6   //Expected Rectangle Size
            }

        };
    }
}
