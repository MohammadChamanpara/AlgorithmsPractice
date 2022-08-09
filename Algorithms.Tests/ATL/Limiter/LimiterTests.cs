using Xunit;
using FluentAssertions;
using System.Threading;

namespace Algorithms.Tests.ATL.Limiter
{
    public class LimiterTests
    {
        [Fact]
        public void RateLimit_WhenRequestsWithinLimit_ShouldReturnTrue()
        {
            //Arrange
            int timeFrame = 2;
            int reguestLimit = 2;
            var rateLimiter = new Limiter(timeFrame, reguestLimit);
            int customerId = 1;

            //Act
            bool served = rateLimiter.Limit(customerId);

            //Assert
            served.Should().Be(true);
        }

        [Fact]
        public void RateLimit_WhenRequestsExceededLimit_ShouldReturnFalse()
        {
            //Arrange
            int timeFrame = 2;
            int reguestLimit = 2;
            var rateLimiter = new Limiter(timeFrame, reguestLimit);
            int customerId = 1;

            //Act
            rateLimiter.Limit(customerId);
            rateLimiter.Limit(customerId);
            rateLimiter.Limit(customerId);
            rateLimiter.Limit(customerId);
            rateLimiter.Limit(customerId);
            rateLimiter.Limit(customerId);
            bool served = rateLimiter.Limit(customerId);

            //Assert
            served.Should().Be(false);
        }

        [Fact]
        public void RateLimit_WhenRequestIsExpired_ShouldReturnTrue()
        {
            //Arrange
            int timeFrame = 100;
            int reguestLimit = 1;
            var rateLimiter = new Limiter(timeFrame, reguestLimit);
            int customerId = 1;

            //Act
            bool firstTime = rateLimiter.Limit(customerId);
            bool secondTime = rateLimiter.Limit(customerId);
            Thread.Sleep(101);
            bool thirdTime = rateLimiter.Limit(customerId);


            //Assert
            firstTime.Should().Be(true);
            secondTime.Should().Be(false);
            thirdTime.Should().Be(true);
        }

    }
}