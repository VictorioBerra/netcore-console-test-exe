using CliWrap;

namespace MyApp.Console.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1Async()
    {
        var result = await Cli.Wrap("MyApp.Console.exe")
            .WithArguments(new[] { "--foo", "bar" })
            .ExecuteAsync();
    }
}