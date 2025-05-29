namespace LegacyTesting;

public class OutputProxy
{
    private readonly TextWriter _originalTextWriter;

    public OutputProxy(TextWriter original)
    {
        _originalTextWriter = original;
    }

    public virtual void WriteLine(string s)
    {
        _originalTextWriter.WriteLine(s);
    }

    public virtual void WriteLine(
        string format, params object?[] arguments)
    {
        _originalTextWriter.WriteLine(format, arguments);
    }
}
