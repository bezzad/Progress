namespace Progress;

public static class ConsoleUtility
{
    private const char Block = '■';
    private const string Twirl = "-\\|/";
    private static readonly int MaxLength = 50;
    private static readonly string ClearLine = string.Concat(Enumerable.Repeat("\b", MaxLength + 9));
    private static bool Initialed = false;

    public static void WriteProgressBar(float percent)
    {
        if (Initialed)
            Console.Write(ClearLine);
        else
            Initialed = true;

        WriteProgress(percent);
    }

    private static void WriteProgress(float percent)
    {
        Console.Write("[");
        var p = (int)((percent * MaxLength / 100) + 0.5f);
        for (var i = 0; i < MaxLength; ++i) 
            Console.Write(i >= p ? ' ' : Block);

        Console.Write("] {0,3:##0}%  ", percent);
        WaitProgress((int)percent);
    }

    private static void WaitProgress(int progress)
    {
        Console.Write("\b");
        Console.Write(Twirl[progress % Twirl.Length]);
    }
}