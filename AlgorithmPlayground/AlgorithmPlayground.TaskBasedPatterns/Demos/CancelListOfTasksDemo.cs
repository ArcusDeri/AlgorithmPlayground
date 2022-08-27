namespace AlgorithmPlayground.TaskBasedPatterns.Demos;

public static class CancelListOfTasksDemo
{
    public static async Task Run()
    {
        Console.WriteLine($"Inside");
        await Task.Delay(300);
        Console.WriteLine("Exit");
    }
}