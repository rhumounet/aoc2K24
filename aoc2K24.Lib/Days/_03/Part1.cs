using System.Globalization;
using System.Text.RegularExpressions;
namespace aoc2K24.Days._03;

public partial class Part1(string filePath) : AbstractSolver(filePath)
{
    public Part1() : this("Days/_03/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        var regex = MulRegex();
        var safe = lines.Aggregate((x,y) => $"{x}{y}");
        var result = 0;
        foreach (Match match in regex.Matches(safe))
        {
            result += Convert.ToInt32(match.Groups[1].Value, CultureInfo.InvariantCulture)
                * Convert.ToInt32(match.Groups[2].Value, CultureInfo.InvariantCulture);
        }
        return Task.FromResult($"{result}");
    }

    [GeneratedRegex("mul\\((\\d{1,3}),(\\d{1,3})\\)")]
    private static partial Regex MulRegex();
}

public class TestPart1() : Part1("Days/_03/test1.txt")
{

}
