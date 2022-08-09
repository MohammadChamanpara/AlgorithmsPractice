using Xunit;
using FluentAssertions;

namespace Algorithms.Tests.ATL.Router
{
    public class RouterTests
    {
        [Fact]
        public void Route_WhenRouteIsRegistered_ShouldReturnResult()
        {
            //Arrange
            var router = new Router();
            string path = "path";
            string expectedResult = "result";

            //Act
            router.WithRoute(path, expectedResult);
            var result = router.Route(path);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Route_WhenRouteIsRegex_ShouldBeAbleToFindIt()
        {
            //Arrange
            var router = new Router();
            string registeredPath = "/bar/*/baz";
            string userPath = "/bar/any/baz";
            string expectedResult = "result";

            //Act
            router.WithRoute(registeredPath, expectedResult);
            var result = router.Route(userPath);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}