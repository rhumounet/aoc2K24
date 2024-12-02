using aoc2K24.Days._01;
using Xunit.Abstractions;
namespace aoc2K24;

public class Day01Tests(ITestOutputHelper helper) : AbstractDayTest<Part1, Part2>(helper)
{
    [Fact]
    public async Task Part01_Test()
    {
        var solver = new TestPart1();
        var (result, _) = await solver.Result();
        Assert.Equal("11", result);
    }

    [Fact]
    public async Task Part02_Test()
    {
        var solver = new TestPart2();
        var (result, _) = await solver.Result();
        Assert.Equal("31", result);
    }
}
