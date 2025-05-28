namespace LegacyTesting;

public class OutputProxy
{
    private readonly TextWriter originalTextWriter;

    public OutputProxy(TextWriter original)
    {
        originalTextWriter = original;
    }

    public virtual void WriteLine(string s)
    {
        originalTextWriter.WriteLine(s);
    }

    public virtual void WriteLine(
        string format, params object?[] arguments)
    {
        originalTextWriter.WriteLine(format, arguments);
    }
}
