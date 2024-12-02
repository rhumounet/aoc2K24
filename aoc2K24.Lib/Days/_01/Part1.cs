using System.Globalization;

namespace aoc2K24.Days._01;

public class Part1(string filePath) : AbstractSolver(filePath)
{
    public Part1() : this("Days/_01/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        var pairs = lines.Select(l => l.Split("   ")).Select(l => (l[0], l[1]));
        var left = pairs.Select(p => Convert.ToInt32(p.Item1, CultureInfo.InvariantCulture)).OrderBy(i => i).ToList();
        var right = pairs.Select(p => Convert.ToInt32(p.Item2, CultureInfo.InvariantCulture)).OrderBy(i => i).ToList();
        var result = 0;
        for (int i = 0; i < left.Count; i++)
        {
            result += Math.Abs(left[i] - right[i]);
        }
        return Task.FromResult($"{result}");
    }
}

public class TestPart1() : Part1("Days/_01/test.txt")
{

}
