namespace AlgorithmPlayground.Core.Algorithms;

public class CanConstructRightAngledTriangle
{
    public static bool CanConstruct(float[] sides)
    {
        if (sides.Length < 3)
        {
            return false;
        }

        var dict = new Dictionary<float, float>();
        foreach (var side in sides)
        {
            var sideSquared = side * side;
            dict[sideSquared] = side;
        }

        for (int i = 0; i < sides.Length; i++)
        {
            for (int j = i + 1; j < sides.Length; j++)
            {
                var squaresSum = sides[i] * sides[i] + sides[j] * sides[j];
                if (dict.ContainsKey(squaresSum))
                {
                    return true;
                }
            }
        }

        return false;
    }
}