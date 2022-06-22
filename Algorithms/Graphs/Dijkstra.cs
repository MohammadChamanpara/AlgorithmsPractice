using System;
using System.Linq;

namespace Algorithms.Graphs
{
    public class Dijkstra
    {
        public static int Run(int[,] graph, int source, int destination)
        {
            int verticesCount = graph.GetLength(0);

            var completed = new bool[verticesCount];
            var distances = Enumerable.Repeat(int.MaxValue, verticesCount).ToArray();

            distances[source] = 0;

            for (int i = 1; i < verticesCount; i++)
            {
                var closest = FindClosestVertex(distances, completed);
                completed[closest] = true;

                for (int vertex = 0; vertex < verticesCount; vertex++)
                {
                    if (completed[vertex])
                        continue;

                    if (graph[closest, vertex] == 0)
                        continue;

                    int newDistance = distances[closest] + graph[closest, vertex];
                    distances[vertex] = Math.Min(distances[vertex], newDistance);
                }
            }

            return distances[destination];
        }

        private static int FindClosestVertex(int[] distances, bool[] completed)
        {
            int min = int.MaxValue;
            int minVertex = -1;

            for (int vertex = 0; vertex < distances.Length; vertex++)
            {
                if (completed[vertex])
                    continue;

                if (distances[vertex] < min)
                {
                    minVertex = vertex;
                    min = distances[vertex];
                }
            }
            return minVertex;
        }
    }
}