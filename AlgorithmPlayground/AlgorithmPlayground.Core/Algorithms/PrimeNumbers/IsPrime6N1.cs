namespace AlgorithmPlayground.Core.Algorithms.PrimeNumbers;

public static class IsPrime6N1
{
    /// <summary>
    /// This algorithm leverages the fact, that any prime number larger than 3 can be
    /// represented in form 6n+-1 (where n is a natural number). This method is called
    /// "trial division".
    /// </summary>
    public static bool IsPrime(int n)
    {
        switch (n)
        {
            case <= 1:
                return false;
            case <= 3:
                return true;
        }

        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (var i = 5; i * i <= n; i += 6)
        {
            // With this condition we omit numbers divisible by 2 or 3,
            // in other words, we check if n is divisible by other prime number less
            // less than n.
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}