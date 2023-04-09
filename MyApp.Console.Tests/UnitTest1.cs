using CliWrap;
using MyApp.Console.Tests.Infrastructure;

namespace MyApp.Console.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1Async()
    {
        using var capture = new ConsoleCapture();
        var res = Program.Main(new[] { "--foo", "bar" });
        
        var actualString = capture.GetAll();
        Assert.Equal(0, res);
        Assert.Contains("Hello", actualString);
        Assert.Contains("foo", actualString);
        Assert.Contains("bar", actualString);
    }
}