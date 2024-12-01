using System.Globalization;

namespace aoc2K24.Days._01;

internal class Part2(string locationPath = "./", string filePath = "Days/_01/data.txt") : AbstractSolver($"{locationPath}{filePath}")
{
    public override Task<string> Run(string[] lines)
    {
        var pairs = lines.Select(l => l.Split("   ")).Select(l => (l[0], l[1]));
        var left = pairs.Select(p => Convert.ToInt32(p.Item1, CultureInfo.InvariantCulture)).OrderBy(i => i).ToList();
        var right = pairs.Select(p => Convert.ToInt32(p.Item2, CultureInfo.InvariantCulture)).OrderBy(i => i).ToList();
        var result = 0;
        for (int i = 0; i < left.Count; i++)
        {
            result += Math.Abs(left[i] * right.Count(k => k == left[i]));
        }
        return Task.FromResult($"{result}");
    }
}

internal class TestPart2(string locationPath = "./") : Part2(locationPath, "Days/_01/test.txt")
{

}
