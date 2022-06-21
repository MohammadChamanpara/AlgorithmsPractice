using Algorithms.Matrix;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class FindInSortedMatrixTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] matrix, int key, (int, int) expectedPosition)
        {
            //Act
            (int row, int col) = FindInSortedMatrix.Run(matrix, key);

            //Assert
            (row, col).Should().BeEquivalentTo(expectedPosition);
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2,  3  },
                    { 5, 8,  10 },
                    { 6, 11, 12 },
                    { 15, 20, 25 }
                },
                5,
                (1,0)
            },

            new object[]
            {
                new[,]
                {
                    { 1, 2,  3  },
                    { 5, 8,  10 },
                    { 6, 11, 12 },
                    { 15, 20, 25 }
                },
                11,
                (2,1)
            },
            new object[]
            {
                new[,]
                {
                    { 1, 2,  3  },
                    { 5, 8,  10 },
                    { 6, 11, 12 },
                    { 15, 20, 25 }
                },
                25,
                (3,2)
            }
        };
    }
}