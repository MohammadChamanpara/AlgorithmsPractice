using Xunit;
using FluentAssertions;

namespace Algorithms.Tests.ATL.Snake
{
    public class SnakeTests
    {
        [Fact]
        public void Move_WhenSnakeHitsAWall_GameOver()
        {
            /*
            100
            000
            000
            */

            //Arrange
            var foods = new (int, int)[] { };
            var snakeGame = new SnakeGame(width: 3, height: 3, foods);

            //Act
            int score = snakeGame.Move(Directions.Up);

            //Assert
            score.Should().Be(-1);
        }

        [Fact]
        public void Move_WhenWithinBoardWithNoFood_ReturnsScore()
        {
            /*
            100
            000
            000
            */

            //Arrange
            var foods = new (int, int)[] { };

            var snakeGame = new SnakeGame(width: 3, height: 3, foods);

            //Act
            snakeGame.Move(Directions.Right);
            int score = snakeGame.Move(Directions.Right);

            //Assert
            score.Should().Be(1);
        }

        [Fact]
        public void Move_WhenFoodAvailable_CanEat()
        {
            /*
            1X0
            0X0
            000
            */

            //Arrange
            (int, int)[] foods = new (int, int)[] { (0, 1), (1, 1) };
            var snakeGame = new SnakeGame(width: 3, height: 3, foods);

            //Act
            int score1 = snakeGame.Move(Directions.Right);
            int score2 = snakeGame.Move(Directions.Down);
            int score3 = snakeGame.Move(Directions.Right);
            int score4 = snakeGame.Move(Directions.Down);
            int score5 = snakeGame.Move(Directions.Down);

            //Assert
            score1.Should().Be(2);
            score2.Should().Be(3);
            score3.Should().Be(3);
            score4.Should().Be(3);
            score5.Should().Be(-1);
        }

        [Fact]
        public void Move_WhenSnakeEatsownBody_GameOver()
        {
            /*
            0XX
            00X
            000
            */

            //Arrange
            (int, int)[] foods = new (int, int)[] { (0, 1), (0, 2), (1, 2) };
            var snakeGame = new SnakeGame(width: 3, height: 3, foods);

            //Act
            int score1 = snakeGame.Move(Directions.Right);
            int score2 = snakeGame.Move(Directions.Right);
            int score3 = snakeGame.Move(Directions.Down);
            int score4 = snakeGame.Move(Directions.Left);
            int score5 = snakeGame.Move(Directions.Up);

            //Assert
            score1.Should().Be(2);
            score2.Should().Be(3);
            score3.Should().Be(4);
            score4.Should().Be(4);
            score5.Should().Be(-1);
        }

        [Fact]
        public void Move_WhenFoodAvailable_EatsInOrder()
        {
            /*
            0XX
            00X
            000
            */

            //Arrange
            (int, int)[] foods = new (int, int)[] { (0, 1), (0, 2), (1, 2) };
            var snakeGame = new SnakeGame(width: 3, height: 3, foods);

            //Act
            int score1 = snakeGame.Move(Directions.Down);
            int score2 = snakeGame.Move(Directions.Right);
            int score3 = snakeGame.Move(Directions.Right);
            int score4 = snakeGame.Move(Directions.Up);
            int score5 = snakeGame.Move(Directions.Left);
            int score6 = snakeGame.Move(Directions.Left);
            int score7 = snakeGame.Move(Directions.Left);

            //Assert
            score1.Should().Be(1);
            score2.Should().Be(1);
            score3.Should().Be(1);
            score4.Should().Be(1);
            score5.Should().Be(2);
            score6.Should().Be(2);
            score7.Should().Be(-1);
        }
    }
}