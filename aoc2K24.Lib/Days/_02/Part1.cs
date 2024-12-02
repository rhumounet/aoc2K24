using System.Globalization;
namespace aoc2K24.Days._02;

public class Part1(string filePath) : AbstractSolver(filePath)
{
    public Part1() : this("Days/_02/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        var safe = lines.Select(l =>
        {
            var values = l.Split(' ').Select(l => Convert.ToInt32(l, CultureInfo.InvariantCulture)).ToList();
            int sign = Math.Sign(values[0] - values[1]);
            if (sign == 0)
                return 0;
            for (int i = 0; i < values.Count - 1; i++)
            {
                var diff = values[i] - values[i + 1];
                var diffSign = Math.Sign(diff);
                if (Math.Abs(diff) <= 3 && diffSign != 0 && sign == diffSign)
                    continue;
                return 0;
            }
            return 1;
        }).Sum();
        return Task.FromResult($"{safe}");
    }
}

public class TestPart1() : Part1("Days/_02/test.txt")
{

}
