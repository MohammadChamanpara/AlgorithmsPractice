using Algorithms.Graphs;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests.Graphs
{
    public class GraphDeepCopyTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(Graph graph, Graph expectedCopy)
        {
            //Act
            var copy = graph.DeepCopy();

            //Assert
            copy.ToString().Should().Be(expectedCopy.ToString());

        }

        public static object[] TestData => new object[]
        {
            new object[] { Graph.Generate(), Graph.Generate() }
        };
    }
}