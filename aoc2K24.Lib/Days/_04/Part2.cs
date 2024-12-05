using System.Globalization;
using System.Text.RegularExpressions;

namespace aoc2K24.Days._04;

public partial class Part2(string filePath) : AbstractSolver(filePath)
{
    public Part2() : this("Days/_04/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        int xLength = lines[0].Length;
        int yLength = lines.Length;
        Dictionary<(int ax, int ay), int> values = [];
        for (int y = 0; y < yLength; y++)
            for (int x = 0; x < xLength; x++)
            {
                var ms = lines[y][x];
                if (ms is 'S' or 'M')
                    if (x + 1 < xLength && y + 1 < yLength && lines[y + 1][x + 1] is 'A')
                        if (x + 2 < xLength && y + 2 < yLength && lines[y + 2][x + 2] == reverse(ms))
                            if (values.ContainsKey((x + 1, y + 1)))
                                values[(x + 1, y + 1)]++;
                            else
                                values.Add((x + 1, y + 1), 1);
                if (x - 1 > 0 && y + 1 < yLength && lines[y + 1][x - 1] is 'A')
                    if (x - 2 >= 0 && y + 2 < yLength && lines[y + 2][x - 2] == reverse(ms))
                        if (values.ContainsKey((x - 1, y + 1)))
                            values[(x - 1, y + 1)]++;
                        else
                            values.Add((x - 1, y + 1), 1);
            }
        return Task.FromResult($"{values.Count(v => v.Value > 1)}");
    }

    char reverse(char c) => c switch
    {
        'M' => 'S',
        'S' => 'M',
        _ => 'L'
    };
}

public class TestPart2() : Part2("Days/_04/test2.txt")
{

}
