using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace Algorithms.Tests.ATL.Vote
{
    public class VoteTests
    {
        [Fact]
        public void FindWinner_WhenThereIsAWinner_ShouldOrderWinners()
        {
            //Arrange
            var votes = new List<Vote>
            {
                new Vote() { Candidates = new() { "A", "B" } },
                new Vote() { Candidates = new() { "B", "C" } },
                new Vote() { Candidates = new() { "B" } }
            };
            // A: 3
            // B: 2+3+3
            // C: 2

            List<string> expectedOrder = new() { "B", "A", "C" };

            ITieBreaker tieBreaker = new TieBreaker();

            //Act
            List<string> candidatesOrder = VoteSystem.FindWinner(votes, tieBreaker);

            //Assert
            candidatesOrder.Should().BeEquivalentTo
            (
                expectedOrder,
                options => options.WithStrictOrdering()
            );


        }
        [Fact]
        public void FindWinner_WhenThereIsATie_ShouldOrderWinners()
        {
            //Arrange
            var votes = new List<Vote>
            {
                new Vote() { Candidates = new() { "A", "X" } },
                new Vote() { Candidates = new() { "B", "Y" } },
                new Vote() { Candidates = new() { "B", "Y" } },
                new Vote() { Candidates = new() { "A", "X" } }
            };

            List<string> expectedOrder = new() { "B", "A", "Y", "X" };

            ITieBreaker tieBreaker = new TieBreaker();

            //Act
            List<string> candidatesOrder = VoteSystem.FindWinner(votes, tieBreaker);

            //Assert
            candidatesOrder.Should().BeEquivalentTo
            (
                expectedOrder,
                options => options.WithStrictOrdering()
            );

        }
    }
}