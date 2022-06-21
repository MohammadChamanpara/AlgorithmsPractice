using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class PeopleMatrixTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] matrix, (int Row, int Column) expectedMeetingPoint)
        {
            //Act
            (int row, int col) = PeopleMatrix.Run(matrix);

            //Assert
            (row, col).Should().Be(expectedMeetingPoint);
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new int[,]
                {
                    { 0, 0, 0, 1, 0, 1 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 1 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                },
                (1, 4)
            },

            new object[]
            {
                new int[,]
                {
                    { 1, 0, 0, 0, 0, 1 },
                    { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                },
                (0, 2)
            }
        };
    }
}