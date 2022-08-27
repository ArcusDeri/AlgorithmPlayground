using AlgorithmPlayground.TaskBasedPatterns.Demos;

namespace AlgorithmPlayground.TaskBasedPatterns;

public class MenuOption
{
    public Func<Task> Operation;
    public string Description { get; set; }

    public MenuOption(string description, Func<Task> operation)
    {
        Description = description;
        Operation = operation;
    }
}