namespace Algorithms.Tests.ATL.Snake
{
    internal class Snake
    {
        private readonly Queue<(int, int)> _body;
        private readonly HashSet<(int, int)> _bodyCells;

        public Snake((int, int) startPosition)
        {
            _body = new Queue<(int, int)>(new[] { startPosition });
            _bodyCells = new HashSet<(int, int)>(new[] { startPosition });
        }

        internal (int, int) Head()
        {
            return _body.Last();
        }

        internal void Eat((int, int) destination)
        {
            _bodyCells.Add(destination);
            _body.Enqueue(destination);
        }

        internal void Move((int, int) destination)
        {
            _body.Enqueue(destination);
            var tail = _body.Dequeue();

            _bodyCells.Add(destination);
            _bodyCells.Remove(tail);
        }

        internal int Size()
        {
            return _body.Count;
        }

        internal bool ExistsIn((int Row, int Col) destination)
        {
            return _bodyCells.Contains(destination);
        }
    }
}