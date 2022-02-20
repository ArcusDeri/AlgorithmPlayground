namespace AlgorithmPlayground.Core.Extensions;

public static class EnumerableExtensions
{
    public static string ToFriendlyArrayString(this IEnumerable<int> collection)
        => $"[{string.Join(", ", collection)}]";
}