namespace AlgorithmPlayground.TaskBasedPatterns.Demos;

public static class CancelTasksAfterTimeout
{
    public static async Task Run()
    {
        Console.WriteLine("Inside");
        await Task.Delay(500);
        Console.WriteLine("Out");
    }
}