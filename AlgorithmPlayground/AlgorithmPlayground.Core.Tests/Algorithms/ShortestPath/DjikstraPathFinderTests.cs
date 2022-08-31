using System.Linq;
using AlgorithmPlayground.Core.Algorithms.ShortestPath;
using AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.ShortestPath;

public class DjikstraPathFinderTests
{
    [Fact]
    public void Resolve_ShouldReturnCorrectPaths_WhenCalledForScenario1()
    {
        // Arrange
        var problemGraph = new VertexEdge[]
        {
            new ("S", "A", 4),
            new ("S", "E", 2),
            new ("A", "D", 3),
            new ("A", "B", 5),
            new ("A", "C", 6),
            new ("B", "A", 3),
            new ("C", "B", 1),
            new ("D", "C", 3),
            new ("D", "A", 1),
            new ("E", "D", 1)
        };
        
        // Act
        var result = DjikstraPathFinder.Resolve(problemGraph, "S");

        // Assert
        Assert.NotEmpty(result);
        Assert.Equal(0, result["S"].TravelCost);
        Assert.Equal(22, result.Sum(s => s.Value.TravelCost));
        Assert.Equal(4, result["A"].TravelCost);
        Assert.Equal(7, result["B"].TravelCost);
        Assert.Equal(6, result["C"].TravelCost);
        Assert.Equal(3, result["D"].TravelCost);
        Assert.Equal(2, result["E"].TravelCost);
    }
}