using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class AntiDiagonalsTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] matrix, List<List<int>> expectedResult)
        {
            //Act
            var result = AntiDiagonals.Run(matrix);

            //Assert
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new[,]
                {
                    { 1 }
                },
                new List<List<int>>
                {
                    new[] { 1 }.ToList()
                }
            },
            new object[]
            {
                new[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                new List<List<int>>
                {
                    new[] {1}.ToList(),
                    new[] {2, 4}.ToList(),
                    new[] {3, 5, 7}.ToList(),
                    new[] {6, 8}.ToList(),
                    new[] {9}.ToList()
                }
            }
        };
    }
}