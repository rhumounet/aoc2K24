using System.Globalization;
using System.Text.RegularExpressions;

namespace aoc2K24.Days._05;

public partial class Part2(string filePath) : AbstractSolver(filePath)
{
    public Part2() : this("Days/_05/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        var firstPart = lines
            .TakeWhile(s => s.Contains('|'));
        var rules = firstPart
            .Select(r =>
            {
                var split = r.Split("|");
                return (int.Parse(split[0]), int.Parse(split[1]));
            });
        var lists = lines.Except(firstPart).Skip(1).Select(s => s.Split(',').Select(v => Convert.ToInt32(v)).ToList());
        var result = 0;
        foreach (var line in lists)
        {
            var concernedRules = rules.Where(t => line.Contains(t.Item1) && line.Contains(t.Item2));
            if (!concernedRules.All(r => CheckOrder(r, line)))
            {
                var start = concernedRules
                    .SelectMany(s => new List<int> { s.Item1, s.Item2 })
                    .Distinct()
                    .ToDictionary(s => s, s => 100);
                foreach (var rule in concernedRules)
                {
                    start[rule.Item1]++;
                    start[rule.Item2]--;
                }
                var reordered = start.OrderByDescending(k => k.Value).Select(k => k.Key).ToList();
                result += reordered[reordered.Count / 2];
            }
        }
        return Task.FromResult($"{result}");
    }

    private static bool CheckOrder((int, int) rule, List<int> line)
        => line.IndexOf(rule.Item1) < line.IndexOf(rule.Item2);
}

public class TestPart2() : Part2("Days/_05/test.txt")
{

}
