namespace AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;

public class VertexPath
{
    public string DestinationVertexName { get; }
    public int TravelCost { get; set; }
    public List<string> Path { get; }

    public VertexPath(string destinationVertexName)
    {
        DestinationVertexName = destinationVertexName;
        Path = new List<string>();
        TravelCost = int.MaxValue;
    }
}