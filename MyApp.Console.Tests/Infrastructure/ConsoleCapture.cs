namespace MyApp.Console.Tests.Infrastructure;

using System;

public sealed class ConsoleCapture : IDisposable
{
    private readonly StringWriter _stringWriter = new();

    private readonly TextWriter _oldOut;
    private readonly TextWriter _oldErr;

    public ConsoleCapture()
    {
        _oldOut = Console.Out;
        _oldErr = Console.Error;

        Console.SetOut(_stringWriter);
        Console.SetError(_stringWriter);
    }

    public string GetAll()
    {
        return _stringWriter.ToString();
    }

    public void Dispose()
    {
        Console.SetOut(_oldOut);
        Console.SetError(_oldErr);

        _stringWriter.Dispose();
    }
}