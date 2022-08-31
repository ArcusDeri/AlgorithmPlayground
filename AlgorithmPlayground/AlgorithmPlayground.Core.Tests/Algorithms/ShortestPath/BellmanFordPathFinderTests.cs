using System.Linq;
using AlgorithmPlayground.Core.Algorithms.ShortestPath;
using AlgorithmPlayground.Core.Algorithms.ShortestPath.Model;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.ShortestPath;

public class BellmanFordPathFinderTests
{
    
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
            new ("E", "D", 8)
        };

        // Act
        var result = BellmanFordPathFinder.Resolve(problemGraph, "S");

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

    [Fact]
    public void Resolve_ShouldReturnCorrectPaths_WhenCalledForScenario2()
    {
        // Arrange
        /*
         *  S ----
         *  |     \
         *  |      | 
         *  |     (1)
         *  |      |
         *  |      v
         *  |      A
         *  |      |
         *  |     (1)
         *  |      |
         *  |      v
         * (10)    B
         *  |      |
         *  |     (1)
         *  |      |
         *  |      v
         *  |      C
         *  |      |
         *  |     (1)
         *  |      |
         *  |     /
         *  |   /
         *  v  /
         *  D <
         */
        var problemGraph = new VertexEdge[]
        {
            new ("S", "D", 10),
            new ("S", "A", 1),
            new ("A", "B", 1),
            new ("B", "C", 1),
            new ("C", "D", 1)
        };

        // Act
        var result = BellmanFordPathFinder.Resolve(problemGraph, "S");

        // Assert
        Assert.NotEmpty(result);
        Assert.Equal(0, result["S"].TravelCost);
        Assert.Equal(10, result.Sum(s => s.Value.TravelCost));
        Assert.Equal(1, result["A"].TravelCost);
        Assert.Equal(2, result["B"].TravelCost);
        Assert.Equal(3, result["C"].TravelCost);
        Assert.Equal(4, result["D"].TravelCost);
    }
}