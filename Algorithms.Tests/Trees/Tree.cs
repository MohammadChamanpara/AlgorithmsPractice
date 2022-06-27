using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Trees
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            Value = value;
        }

        public TreeNode? Left;
        public TreeNode? Right;
        public TreeNode? Sibling;
        public int Value;
    }

    public class Tree
    {
        private TreeNode? _root;

        public static Tree Generate1to7()
        {
            var tree = new Tree();

            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);
            var node6 = new TreeNode(6);
            var node7 = new TreeNode(7);

            tree._root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            return tree;
        }

        public void ConnectSiblings()
        {
            if (_root == null)
                return;

            var q = new Queue<TreeNode>();
            q.Enqueue(_root);
            TreeNode? previous = null;
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                if (previous == null)
                    previous = node;
                else
                {
                    previous.Sibling = node;
                    previous = node;
                }

                if (node.Left != null)
                    q.Enqueue(node.Left);

                if (node.Right != null)
                    q.Enqueue(node.Right);
            }
        }

        public string LevelOrder(bool printSiblings = false)
        {
            if (_root == null)
                return "";

            var order = new StringBuilder();
            var q = new Queue<TreeNode>();
            q.Enqueue(_root);

            while (q.Count > 0)
            {
                var node = q.Dequeue();

                order.Append(node.Value);
                if (printSiblings)
                    order.Append($"({node.Sibling?.Value})");

                if (node.Left != null)
                    q.Enqueue(node.Left);

                if (node.Right != null)
                    q.Enqueue(node.Right);
            }
            return order.ToString();
        }
    }
}