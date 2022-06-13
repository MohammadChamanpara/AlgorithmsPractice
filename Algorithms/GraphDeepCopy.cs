using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class GraphNode
    {
        public GraphNode(int value)
        {
            Value = value;
        }

        public List<GraphNode> Connections = new();
        public int Value;

        public override string ToString()
        {
            var s = new StringBuilder($"({Value}) Connections: [ ");
            foreach (GraphNode node in Connections)
                s.Append($"{node.Value} ");
            s.Append("] \r\n");

            return s.ToString();
        }

    }

    public class Graph
    {
        private GraphNode? _root;

        public static Graph Generate()
        {
            var node1 = new GraphNode(1);
            var node2 = new GraphNode(2);
            var node3 = new GraphNode(3);
            var node4 = new GraphNode(4);

            node1.Connections.AddRange(new[] { node2, node3 });
            node2.Connections.Add(node4);
            node3.Connections.Add(node4);
            node4.Connections.Add(node1);

            return new Graph() { _root = node1 };
        }


        public Graph DeepCopy()
        {
            if (_root == null)
                throw new InvalidOperationException();

            Dictionary<GraphNode, GraphNode> nodeMap = new();

            AddAllNodesToMap(_root, nodeMap);

            ConnectAllLinks(nodeMap);

            return new Graph() { _root = nodeMap[_root] };
        }

        private static void ConnectAllLinks(Dictionary<GraphNode, GraphNode> nodeMap)
        {
            foreach (GraphNode node in nodeMap.Keys)
            {
                foreach (var connection in node.Connections)
                    nodeMap[node].Connections.Add(nodeMap[connection]);
            }
        }

        private void AddAllNodesToMap(GraphNode node, Dictionary<GraphNode, GraphNode> nodeMap)
        {
            if (nodeMap.ContainsKey(node))
                return;

            nodeMap.Add(node, new GraphNode(node.Value));

            foreach (var connection in node.Connections)
                AddAllNodesToMap(connection, nodeMap);
        }

        public override string ToString()
        {
            if (_root == null)
                return "";

            var set = new HashSet<GraphNode>();
            return $"Root-> {ToString(_root, set)}";
        }

        private string ToString(GraphNode node, HashSet<GraphNode> set)
        {
            if (set.Contains(node))
                return "";

            set.Add(node);

            var s = new StringBuilder(node.ToString());
            foreach (var connection in node.Connections)
                s.Append(ToString(connection, set));

            return s.ToString();
        }
    }
}