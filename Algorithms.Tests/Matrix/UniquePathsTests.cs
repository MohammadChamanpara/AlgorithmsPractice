using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Tests.Matrix
{
    public class UniquePathsTests
    {
        [Theory]
        [InlineData(2, 2, 2)]
        public void Test(int a, int b, int expectedPaths)
        {
            //Act
            var result = UniquePaths.Run(a, b);

            //Assert
            result.Should().Be(expectedPaths);
        }
    }
}