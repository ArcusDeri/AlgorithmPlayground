using AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;

namespace AlgorithmPlayground.Core.Algorithms.ShortestPath;

public class BellmanFordPathFinder
{
    public static Dictionary<string, VertexPath> Resolve(VertexEdge[] graph, string startVertex)
    {
        var pathTable = graph.Select(e => e.From)
            .Union(graph.Select(e => e.To))
            .Distinct()
            .ToDictionary(k => k, v => new VertexPath(v));
        pathTable[startVertex].TravelCost = 0;
        var vertices = pathTable.Keys;

        bool Relax()
        {
            var shouldIterateAgain = false;
            foreach (var vertex in vertices)
            {
                if (pathTable[vertex].TravelCost == int.MaxValue)
                {
                    // path to current vertex is unknown yet, skip
                    continue;
                }

                var edges = graph.Where(w => w.From == vertex);
                foreach (var edge in edges)
                {
                    int potentialCost;
                    if (pathTable[edge.From].TravelCost == int.MaxValue)
                    {
                        potentialCost = edge.Cost;
                    }
                    else
                    {
                        potentialCost = pathTable[edge.From].TravelCost + edge.Cost;
                    }

                    if (potentialCost < pathTable[edge.To].TravelCost)
                    {
                        pathTable[edge.To].TravelCost = potentialCost;
                        pathTable[edge.To].Path.Clear();
                        pathTable[edge.To].Path.AddRange(pathTable[edge.From].Path);
                        pathTable[edge.To].Path.Add(vertex);
                        shouldIterateAgain = true;
                    }
                }
            }

            return shouldIterateAgain;
        }

        while (Relax())
        {
        }

        return pathTable;
    }
}