namespace AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;

public class VertexEdge
{
    public string From { get; }
    public string To { get; }
    public int Cost { get; }

    public VertexEdge(string from, string to, int cost)
    {
        From = from;
        To = to;
        Cost = cost;
    }
}