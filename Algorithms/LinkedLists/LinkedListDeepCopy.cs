using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    class NodeDeepCopy
    {
        public NodeDeepCopy(int value)
        {
            Value = value;
        }

        public NodeDeepCopy? Next;
        public NodeDeepCopy? Arbitrary;
        public int Value;

        public override string ToString()
        {
            string arbitrary = Arbitrary != null ? Arbitrary.Value.ToString() : "null";
            return $"Value: {Value}. Arbitrary: {arbitrary}";
        }

    }

    public class LinkedListDeepCopy
    {
        private NodeDeepCopy? _head;

        public static LinkedListDeepCopy Generate()
        {
            var result = new LinkedListDeepCopy();
            var node1 = new NodeDeepCopy(1);
            var node2 = new NodeDeepCopy(2);
            var node3 = new NodeDeepCopy(3);
            var node4 = new NodeDeepCopy(4);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            node1.Arbitrary = node4;
            node2.Arbitrary = node4;
            node3.Arbitrary = null;
            node4.Arbitrary = node1;

            result._head = node1;

            return result;
        }

        public LinkedListDeepCopy DeepCopy()
        {
            var nodeMap = new Dictionary<NodeDeepCopy, NodeDeepCopy>();
            var runner = _head;

            while (runner != null)
            {
                var newNode = new NodeDeepCopy(runner.Value);
                nodeMap.Add(runner, newNode);
                runner = runner.Next;
            }

            var result = new LinkedListDeepCopy();
            runner = _head;

            while (runner != null)
            {
                result.AddNode(runner, nodeMap);
                runner = runner.Next;
            }

            return result;
        }

        private void AddNode(NodeDeepCopy runner, Dictionary<NodeDeepCopy, NodeDeepCopy> nodeMap)
        {
            var node = nodeMap[runner];

            if (_head == null)
                _head = node;

            node.Next = runner.Next != null ? nodeMap[runner.Next] : null;
            node.Arbitrary = runner.Arbitrary != null ? nodeMap[runner.Arbitrary] : null;
        }
        public void RemoveFirst()
        {
            _head = _head?.Next;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("Root -> ");
            var runner = _head;
            while (runner != null)
            {
                s.Append($"{runner} -> ");
                runner = runner.Next;
            }
            return s.ToString();
        }

    }
}