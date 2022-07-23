using System.Linq;
using AlgorithmPlayground.Core.Algorithms.ShortestPath;
using AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.ShortestPath;

public class BellmanFordPathFinderTests
{
    private readonly BellmanFordPathFinder _pathFinder = new BellmanFordPathFinder();
    
    [Fact]
    public void Resolve_ShouldReturnCorrectPaths_WhenCalledForScenario1()
    {
        // Arrange
        /*
         *  S --(4)-> A <-(3)-- B
         *  |         ^ \       ^
         *  |         |  \      |
         * (-5)      (10) \    (-2)
         *  |         |   (6)   |
         *  |         |     \   |
         *  v         |      >  |
         *  E --(8)-> D --(3)-> C
         */
        var problemGraph = new VertexEdge[]
        {
            new ("S", "A", 4),
            new ("S", "E", -5),
            new ("A", "C", 6),
            new ("B", "A", 3),
            new ("C", "B", -2),
            new ("D", "C", 3),
            new ("D", "A", 10),
            new ("E", "D", 8),
        };

        // Act
        var result = _pathFinder.Resolve(problemGraph, "S");

        // Assert
        Assert.NotEmpty(result);
        Assert.Equal(0, result["S"].TravelCost);
        Assert.Equal(12, result.Sum(s => s.Value.TravelCost));
        Assert.Equal(4, result["A"].TravelCost);
        Assert.Equal(4, result["B"].TravelCost);
        Assert.Equal(6, result["C"].TravelCost);
        Assert.Equal(3, result["D"].TravelCost);
        Assert.Equal(-5, result["E"].TravelCost);
    }
}