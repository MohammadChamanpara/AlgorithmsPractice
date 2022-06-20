using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class ProductOfAllTests
    {
        [Theory]
        [InlineData(new int[] { }, 1)]
        [InlineData(new[] { 10 }, 1)]
        [InlineData(new[] { -10 }, -1)]
        [InlineData(new[] { 0, -10, -20, -30, 1 }, 0)]
        [InlineData(new[] { -1, -10, -20, -30, 1 }, 1)]
        [InlineData(new[] { -1, -10, -20, 1, 100 }, -1)]
        public void Test(int[] numbers, int expectedProduct)
        {
            //Arrange
            //Act
            int product = ProductOfAll.Run(numbers);

            //Assert
            product.Should().Be(expectedProduct);
        }
    }
}
