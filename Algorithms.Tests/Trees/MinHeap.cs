using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests.Trees
{
    internal class MinHeap
    {
        private readonly int _maxNodesCount;
        private readonly List<int> _nodes = new();
        public MinHeap(int maxNodesCount)
        {
            _maxNodesCount = maxNodesCount;
        }

        public void Insert(int number)
        {
            if (TreeIsFull())
            {
                if (number < Min)
                    return;

                PopMin();
            }

            _nodes.Add(number);
            Heapify(LastIndex());
        }

        private void Heapify(int index)
        {
            if (index <= 0)
                return;

            if (_nodes[index] >= _nodes[index.Parent()])
                return;

            SwapNodesAt(index, index.Parent());
            Heapify(index.Parent());
        }

        private void SwapNodesAt(int index1, int index2)
        {
            (_nodes[index2], _nodes[index1]) = (_nodes[index1], _nodes[index2]);
        }

        private bool TreeIsFull() => _nodes.Count >= _maxNodesCount;

        public bool HasNodes() => _nodes.Count > 0;

        public int PopMin()
        {
            if (!HasNodes())
                throw new InvalidOperationException();

            int min = _nodes[0];

            _nodes[0] = _nodes.Last();

            _nodes.RemoveAt(LastIndex());

            Heapify(LastIndex());

            return min;

        }

        private int LastIndex()
        {
            return _nodes.Count - 1;
        }

        public int? Min => _nodes?.First();
    }

    internal static class HeapExtensions
    {
        public static int Parent(this int index) => (index - 1) / 2;
    }
}