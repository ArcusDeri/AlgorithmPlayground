using AlgorithmPlayground.TaskBasedPatterns.Demos;

namespace AlgorithmPlayground.TaskBasedPatterns;

public static class Program
{
    private static Dictionary<int, MenuOption> _menuOptions = new()
    {
        {1, new MenuOption("Cancel a list of tasks", async () => { await CancelListOfTasksDemo.Run(); })},
        {2, new MenuOption("Cancel tasks after timeout", async () => { await CancelTasksAfterTimeout.Run(); })},
    };

    public static async Task Main()
    {
        ConsoleKey pressedKey;
        var cursorValue = 1;
        do
        {
            Console.Clear();
            Console.WriteLine("Use arrows to select an example program to run (press X to exit):/n");
            foreach (var menuOption in _menuOptions)
            {
                var prefix = menuOption.Key == cursorValue ? "(*) " : new string(' ', 4);
                Console.WriteLine($"{prefix}{menuOption.Value.Description}");
            }

            pressedKey = Console.ReadKey().Key;
            switch (pressedKey)
            {
                case ConsoleKey.UpArrow:
                    cursorValue = cursorValue == 1 ? _menuOptions.Count : cursorValue - 1;
                    break;
                case ConsoleKey.DownArrow:
                    cursorValue = cursorValue == _menuOptions.Count ? 1 : cursorValue + 1;
                    break;
                case ConsoleKey.Enter:
                    await _menuOptions[cursorValue].Operation();
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        } while (pressedKey != ConsoleKey.X);
    }
}
