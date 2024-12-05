namespace aoc2K24.Days._05;

public partial class Part1(string filePath) : AbstractSolver(filePath)
{
    public Part1() : this("Days/_05/data.txt") { }
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
            if (concernedRules.All(r => CheckOrder(r, line)))
                result += line[line.Count / 2];
        }
        return Task.FromResult($"{result}");
    }

    private static bool CheckOrder((int, int) rule, List<int> line)
        => line.IndexOf(rule.Item1) < line.IndexOf(rule.Item2);
}

public class TestPart1() : Part1("Days/_05/test.txt")
{

}
