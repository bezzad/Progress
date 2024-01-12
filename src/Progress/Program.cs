namespace Progress;

public static class Program
{
    private static async Task Main()
    {
        Console.WriteLine("Progress Test");
        ConsoleUtility.WriteProgressBar(0);
        for (var i = 0; i <= 100; ++i)
        {
            ConsoleUtility.WriteProgressBar(i);
            await Task.Delay(50);
        }

        Console.WriteLine();
    }
}