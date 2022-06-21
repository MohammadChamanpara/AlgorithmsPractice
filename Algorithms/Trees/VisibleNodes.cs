using System;
using System.Collections.Generic;

namespace Algorithms.Trees
{
    public class VNTreeNode
    {
        public int Value;
        public VNTreeNode? Left;
        public VNTreeNode? Right;

        public VNTreeNode(int value)
        {
            Value = value;
        }
    }

    public class VisibleNodesTree
    {
        private VNTreeNode? _root;

        public VisibleNodesTree(VNTreeNode? root)
        {
            _root = root;
        }

        private static VNTreeNode? BuildNode(int[] treeNodes, int i)
        {
            if (i >= treeNodes.Length)
                return null;

            return new VNTreeNode(treeNodes[i])
            {
                Left = BuildNode(treeNodes, i * 2 + 1),
                Right = BuildNode(treeNodes, i * 2 + 2)
            };
        }

        private static VisibleNodesTree BuildTree(int[] treeNodes)
        {
            return new VisibleNodesTree(BuildNode(treeNodes, 0));
        }

        public int CountVisibleNodes()
        {
            var maxStack = new Stack<int>(new[] { int.MinValue });
            return CountVisibleNodes(_root, maxStack);
        }

        private int CountVisibleNodes(VNTreeNode? node, Stack<int> maxStack)
        {
            if (node == null)
                return 0;

            int max = maxStack.Peek();
            maxStack.Push(Math.Max(node.Value, max));

            int count = 0;
            if (node.Value > max)
                count++;

            count += CountVisibleNodes(node.Left, maxStack);
            count += CountVisibleNodes(node.Right, maxStack);
            maxStack.Pop();

            return count;
        }

        public static int CountVisibleNodes(int[] treeNodes)
        {
            return BuildTree(treeNodes).CountVisibleNodes();
        }
    }
}