using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class FindSumCombinationsTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int target, List<int>[] expectedCombos)
        {
            //Act
            var result = FindSumCombinations.Run(target);

            //Assert
            result.Should().BeEquivalentTo(expectedCombos);
        }

        public static object[] TestData => new object[]
        {
            new object[] 
            { 
                1, new List<int>[]{ } 
            },
            
            new object[] 
            { 
                2, new [] 
                { 
                    new List<int>{ 1, 1 } 
                } 
            },
            
            new object[] 
            { 
                3, new [] 
                { 
                    new List<int>{ 1, 2 }, 
                    new List<int> { 1, 1, 1 } 
                } 
            },
            
            new object[] 
            { 
                4, new [] 
                { 
                    new List<int> { 1, 3 }, 
                    new List<int> { 1, 2, 1 }, 
                    new List<int> { 1, 1, 1, 1 }, 
                    new List<int> { 2, 2 },
                    new List<int> { 2, 1, 1 } 
                } 
            }
        };
    }
}