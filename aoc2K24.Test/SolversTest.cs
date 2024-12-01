using System.Runtime.CompilerServices;

namespace aoc2K24;

public class SolversTest
{
    const string RELATIVE_BASED = $"";

    [Fact]
    public async Task Day01_Part1()
    {
        var solver = new Days._01.Part1(RELATIVE_BASED);
        Console.WriteLine(await solver.Result());
        Assert.True(true);
    }

    [Fact]
    public async Task Day01_Part01_Test()
    {
        var solver = new Days._01.TestPart1(RELATIVE_BASED);

        Assert.Equal("11", await solver.Result());
    }

    [Fact]
    public async Task Day01_Part2()
    {
        var solver = new Days._01.Part2(RELATIVE_BASED);
        Console.WriteLine(await solver.Result());
        Assert.True(true);
    }

    [Fact]
    public async Task Day01_Part02_Test()
    {
        var solver = new Days._01.TestPart2(RELATIVE_BASED);

        Assert.Equal("31", await solver.Result());
    }
}
