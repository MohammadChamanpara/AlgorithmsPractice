using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Graphs
{
    public class DijkstraTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[,] graph, int source, int destination, int expectedDistance)
        {
            //Act
            int distance = Dijkstra.Run(graph, source, destination);

            //Assert
            distance.Should().Be(expectedDistance);
        }

        public static object[] TestData => new object[]
        {
            new object[]
            {
                new[,]
                {
                    { 0, 2, 0, 8},
                    { 2, 0, 0, 4},
                    { 0, 0, 0, 5},
                    { 8, 4, 5, 0}
                },
                0, //Source
                2, //Destination
                11 //Distance
            },

            new object[]
            {
                new[,]
                {
                    { 0, 2, 0, 8},
                    { 2, 0, 0, 4},
                    { 0, 0, 0, 5},
                    { 8, 4, 5, 0}
                },
                0, //Source
                3, //Destination
                6  //Distance
            }
        };
    }
}
