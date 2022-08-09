namespace Algorithms.Tests.ATL.Snake
{
    internal class SnakeGame
    {
        private readonly (int Height, int Width) _boardSize;
        private readonly Queue<(int, int)> _foods;
        private readonly Snake _snake;
        private const int GAMEOVER = -1;

        public SnakeGame(int width, int height, (int, int)[] foods)
        {
            _boardSize = (height, width);

            _foods = new Queue<(int, int)>(foods);

            _snake = new Snake(startPosition: (0, 0));
        }

        internal int Move(Directions direction)
        {
            var destination = FindDestination(_snake.Head(), direction);

            if (IsOutside(destination))
                return GAMEOVER;

            if (IsFood(destination))
            {
                _snake.Eat(destination);
                return _snake.Size();
            }

            if (_snake.ExistsIn(destination))
                return GAMEOVER;

            _snake.Move(destination);
            return _snake.Size();
        }

        private bool IsFood((int Row, int Col) destination)
        {
            if (!_foods.Any())
                return false;

            if (_foods.Peek() == destination)
            {
                _foods.Dequeue();
                return true;
            }

            return false;
        }

        private bool IsOutside((int Row, int Col) position)
        {
            return
                position.Row < 0 ||
                position.Row >= _boardSize.Height ||

                position.Col < 0 ||
                position.Col >= _boardSize.Width;
        }

        private static (int Row, int Col) FindDestination((int Row, int Col) position, Directions direction)
        {
            return direction switch
            {
                Directions.Up => (position.Row - 1, position.Col),
                Directions.Down => (position.Row + 1, position.Col),
                Directions.Left => (position.Row, position.Col - 1),
                Directions.Right => (position.Row, position.Col + 1),
                _ => throw new Exception("Undefined Diretion")
            };
        }
    }
}