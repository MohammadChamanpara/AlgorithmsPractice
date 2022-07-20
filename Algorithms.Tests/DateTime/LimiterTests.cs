using Xunit;
using FluentAssertions;
using System.Threading;

namespace AtlassianTests
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
            bool served=rateLimiter.limit(customerId);

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
            rateLimiter.limit(customerId);
            rateLimiter.limit(customerId);
            rateLimiter.limit(customerId);
            rateLimiter.limit(customerId);
            rateLimiter.limit(customerId);
            rateLimiter.limit(customerId);
            bool served = rateLimiter.limit(customerId);

            //Assert
            served.Should().Be(false);
        }

        [Fact]
        public void RateLimit_WhenRequestIsExpireed_ShouldReturnTrue()
        {
            //Arrange
            int timeFrame = 1;
            int reguestLimit = 1;
            var rateLimiter = new Limiter(timeFrame, reguestLimit);
            int customerId = 1;

            //Act
            bool firstTime=rateLimiter.limit(customerId);
            bool secondTime= rateLimiter.limit(customerId);
            Thread.Sleep(1100);
            bool thirdTime = rateLimiter.limit(customerId);


            //Assert
            firstTime.Should().Be(true);
            secondTime.Should().Be(false);
            thirdTime.Should().Be(true);
        }

    }
}