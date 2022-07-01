using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class MatrixGenerateSpiralTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int number, int[,] expectedMatrix)
        {
            //Act
            int[,] matrix = MatrixGenerateSpiral.Run(number);

            //Assert
            matrix.Should().BeEquivalentTo(expectedMatrix, options => options.WithStrictOrdering());
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                1,
                new[,]
                {
                    { 1 }
                }
            },

            new object[]
            {
                2,
                new[,]
                {
                    { 1, 2 },
                    { 4, 3 }
                }
            },

            new object[]
            {
                3,
                new[,]
                {
                    { 1, 2, 3 },
                    { 8, 9, 4 },
                    { 7, 6, 5 }
                }
            }
        };
    }
}