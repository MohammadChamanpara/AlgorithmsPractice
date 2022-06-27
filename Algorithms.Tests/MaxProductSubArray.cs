using FluentAssertions;
using System;
using Xunit;

namespace Algorithms.Tests
{
    public class MaxProductSubArray
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1 }, 1)]
        [InlineData(new[] { 3, 2, 1 }, 6)]
        [InlineData(new[] { -2, 2, -2 }, 8)]
        [InlineData(new[] { 2, 3, -2, 4 }, 6)]
        public void Test(int[] numbers, int expectedResult)
        {
            //Act
            int result = Run(numbers);

            //Assert
            result.Should().Be(expectedResult);
        }

        private static int Run(int[] numbers)
        {
            int minSoFar = numbers[0];
            int maxSoFar = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int number = numbers[i];

                minSoFar *= number;
                maxSoFar *= number;

                if (maxSoFar < minSoFar)
                    (maxSoFar, minSoFar) = (minSoFar, maxSoFar);

                minSoFar = Math.Min(minSoFar, number);
                maxSoFar = Math.Max(maxSoFar, number);

                max = Math.Max(max, maxSoFar);
            }

            return max;
        }
    }
}
