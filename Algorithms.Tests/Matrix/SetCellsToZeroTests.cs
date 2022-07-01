using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class SetCellsToZeroTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] matrix, int[,] expectedResult)
        {
            //Act
            SetCellsToZero.Run(matrix);

            //Assert
            matrix.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                new[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 0, 2, 3 },
                    { 4, 5, 6 }
                },
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 5, 6 }
                }
            },

            new object[]
            {
                new[,]
                {
                    { 1, 0, 3 },
                    { 4, 5, 6 }
                },
                new[,]
                {
                    { 0, 0, 0 },
                    { 4, 0, 6 }
                }
            },

            new object[]
            {
                new[,]
                {
                    { 1, 0, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 0 }
                },
                new[,]
                {
                    { 0, 0, 0 },
                    { 4, 0, 0 },
                    { 0, 0, 0 }
                }
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 5, 6 },
                    { 7, 8, 0 }
                },
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                }
            },
        };
    }
}