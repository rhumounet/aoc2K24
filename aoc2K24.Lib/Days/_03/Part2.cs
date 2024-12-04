using System.Globalization;
using System.Text.RegularExpressions;

namespace aoc2K24.Days._03;

public partial class Part2(string filePath) : AbstractSolver(filePath)
{
    public Part2() : this("Days/_03/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        var line = DoDontRegex().Split(lines.Aggregate((x, y) => $"{x}{y}")).Where(s => !s.StartsWith("don't()")).Aggregate((x,y) => $"{x}{y}");
        var result = 0;
        foreach (Match match in MulRegex().Matches(line))
            result += Convert.ToInt32(match.Groups[1].Value, CultureInfo.InvariantCulture)
                * Convert.ToInt32(match.Groups[2].Value, CultureInfo.InvariantCulture);
        return Task.FromResult($"{result}");
    }

    [GeneratedRegex("mul\\((\\d{1,3}),(\\d{1,3})\\)")]
    private static partial Regex MulRegex();

    [GeneratedRegex(@"(?=do\(\)|don't\(\))")]
    private static partial Regex DoDontRegex();
}

public class TestPart2() : Part2("Days/_03/test2.txt")
{

}
