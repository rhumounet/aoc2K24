using Xunit.Abstractions;

namespace aoc2K24;
public abstract class AbstractDayTest<Part1, Part2>(ITestOutputHelper output) 
    where Part1 : class, ISolver, new()
    where Part2 : class, ISolver, new()
{
    [Fact]
    public async Task Part1_RealData()
    {
        var solver = new Part1();
        var (result, elapsed) = await solver.Result();
        output.WriteLine($"{result}, in {elapsed}ms");
    }

    [Fact]
    public async Task Part2_RealData()
    {
        var solver = new Part2();
        var (result, elapsed) = await solver.Result();
        output.WriteLine($"{result}, in {elapsed}ms");
    }
}
