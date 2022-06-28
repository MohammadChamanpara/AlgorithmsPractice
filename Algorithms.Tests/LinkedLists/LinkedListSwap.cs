using System.Text;

namespace Algorithms.Tests.LinkedLists
{
    class NodeSwap
    {
        public NodeSwap(int value)
        {
            Value = value;
        }
        public int Value;
        public NodeSwap? Next;
    }

    internal class LinkedListSwap
    {
        NodeSwap? _head = null;
        NodeSwap? _last = null;

        public LinkedListSwap(int[] items)
        {
            foreach (var item in items)
                AddNode(item);
        }

        private void AddNode(int item)
        {
            var node = new NodeSwap(item);

            if (_last == null)
                _head = _last = node;
            else
            {
                _last.Next = node;
                _last = node;
            }
        }

        public void Swap()
        {
            _head = SwapWithNext(_head);
        }

        private NodeSwap? SwapWithNext(NodeSwap? node)
        {
            if (node == null)
                return null;

            if (node.Next == null)
                return node;

            var first = node;
            var second = node.Next;
            var third = node.Next.Next;

            second.Next = first;

            first.Next = SwapWithNext(third);

            return second;
        }

        public override string ToString()
        {
            var s = new StringBuilder();
            var runner = _head;
            while (runner != null)
            {
                s.Append(runner.Value);
                runner = runner.Next;
            }

            return s.ToString();
        }
    }
}