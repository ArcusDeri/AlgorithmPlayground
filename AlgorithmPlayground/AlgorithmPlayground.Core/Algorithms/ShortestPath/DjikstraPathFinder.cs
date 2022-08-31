using AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;

namespace AlgorithmPlayground.Core.Algorithms.ShortestPath;

public static class DjikstraPathFinder
{
    public static Dictionary<string, VertexPath> Resolve(VertexEdge[] graph, string startVertex)
    {
        var pathTable = graph.Select(e => e.From)
            .Union(graph.Select(e => e.To))
            .Distinct()
            .ToDictionary(k => k, v => new VertexPath(v));
        pathTable[startVertex].TravelCost = 0;
        var verticesVisitedTable = pathTable.ToDictionary(k => k.Key, _ => false);
        var nextVertex = startVertex;
        ResolveForVertex(startVertex);

        while (nextVertex is { })
        {
            ResolveForVertex(nextVertex);
        }

        void ResolveForVertex(string vertex)
        {
            var edges = graph.Where(w => w.From == vertex);
            foreach (var edge in edges)
            {
                var currentVertexCost = pathTable[edge.From].TravelCost;
                var toVertexCost = pathTable[edge.To].TravelCost;
                int potentialCost;
                if (currentVertexCost == int.MaxValue)
                {
                    potentialCost = edge.Cost;
                }
                else
                {
                    potentialCost = currentVertexCost + edge.Cost;
                }

                if (potentialCost < toVertexCost)
                {
                    pathTable[edge.To].TravelCost = potentialCost;
                    pathTable[edge.To].Path.Clear();
                    pathTable[edge.To].Path.AddRange(pathTable[edge.From].Path);
                    pathTable[edge.To].Path.Add(vertex);
                }

            }
            verticesVisitedTable[vertex] = true;
            nextVertex = ResolveNextVertex(nextVertex);
        }

        string? ResolveNextVertex(string currentVertex)
        {
            return pathTable.Where(w => !verticesVisitedTable[w.Key])
                .Select(s => s.Value)
                .MinBy(mb => mb.TravelCost)?
                .DestinationVertexName;
        }

        return pathTable;
    }
}