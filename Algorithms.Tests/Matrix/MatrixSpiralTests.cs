using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class MatrixSpiralTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] matrix, string expectedOrder)
        {
            //Act
            string order = MatrixSpiral.Run(matrix);

            //Assert
            order.Should().Be(expectedOrder);
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2}
                },
                "12"
            },

            new object[]
            {
                new[,]
                {
                    { 1 },
                    { 2 },
                    { 3 }
                },
                "123"
            },

            new object[]
            {
                new[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                "123654"
            },

            new object[]
            {
                new[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                "123698745"
            }
        };
    }
}