using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Strings
{
    internal class KthLargestSubstring
    {
        internal static string Run(string input, int k)
        {
            string[] substrings = Split(input);

            if (k < 1 || k > substrings.Length)
                throw new ArgumentException(
                    $"Argument {nameof(k)} should be between 1 and {substrings.Length}");

            var heap = new StringMinHeap(capacity: k);

            foreach (var substring in substrings)
                heap.Add(substring);

            return heap.Min();
        }


        internal static string Run2(string input, int k)
        {
            string[] substrings = Split(input);

            if (k < 1 || k > substrings.Length)
                throw new ArgumentException(
                    $"Argument {nameof(k)} should be between 1 and {substrings.Length}");

            substrings = SortByLength(substrings);

            return substrings[k - 1];
        }

        private static string[] SortByLength(string[] substrings)
        {
            return substrings
                .OrderByDescending(x => x.Length)
                .ToArray();
        }

        private static string[] Split(string input)
        {
            List<string> substrings = new();
            StringBuilder substring = new(value: input[0].ToString());

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    substrings.Add(substring.ToString());
                    substring = new StringBuilder();
                }
                substring.Append(input[i]);
            }
            if (substring.Length > 0)
                substrings.Add(substring.ToString());

            return substrings.ToArray();
        }


    }

    internal class StringMinHeap
    {
        readonly int capacity;
        readonly List<string> nodes;

        public StringMinHeap(int capacity)
        {
            this.capacity = capacity;
            nodes = new List<string>();
        }


        internal void Add(string item)
        {
            if (TreeIsFull())
            {
                if (item.Length < Min().Length)
                    return;

                RemoveMin();
            }

            nodes.Add(item);
            HeapifyUp(index: LastIndex());
        }

        private void HeapifyUp(int index)
        {
            if (index <= 0)
                return;

            int parent = index.Parent();
            if (nodes[index].Length < nodes[parent].Length)
                Swap(nodes, index, parent);
            HeapifyUp(parent);
        }

        private static void Swap(List<string> nodes, int i, int j)
        {
            (nodes[i], nodes[j]) = (nodes[j], nodes[i]);
        }

        private void RemoveMin()
        {
            nodes[0] = nodes[LastIndex()];
            HeapifyDown(index: 0);
        }

        private void HeapifyDown(int index)
        {
            if (index >= nodes.Count)
                return;

            int left = index.LeftChild();
            int right = index.RightChild();

            if
            (
                (left < nodes.Count && nodes[left].Length < nodes[index].Length) ||
                (right < nodes.Count && nodes[right].Length < nodes[index].Length)
            )
            {
                int smaller =
                    nodes[left].Length < nodes[right].Length
                    ? left
                    : right;

                Swap(nodes, index, smaller);
                HeapifyDown(smaller);
            }

        }

        private int LastIndex()
        {
            return nodes.Count - 1;
        }

        public string Min()
        {
            return nodes[0];
        }

        private bool TreeIsFull()
        {
            return nodes.Count == capacity;
        }
    }
    internal static class HeapExtensions
    {

        public static int Parent(this int index)
        {
            return index / 2;
        }

        public static int LeftChild(this int index)
        {
            return index * 2 + 1;
        }

        public static int RightChild(this int index)
        {
            return index * 2 + 2;

        }

    }
}
