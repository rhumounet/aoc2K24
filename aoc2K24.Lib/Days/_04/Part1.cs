using System.Text.RegularExpressions;
namespace aoc2K24.Days._04;

public partial class Part1(string filePath) : AbstractSolver(filePath)
{
    public Part1() : this("Days/_04/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        int xLength = lines[0].Length;
        int yLength = lines.Length;
        List<string> words = [.. lines];
        HashSet<(int x, int y)> crawledDownRight = [];
        HashSet<(int x, int y)> crawledUpRight = [];
        for (int x = 0; x < xLength; x++)
        {
            var temp = "";
            for (int y = 0; y < yLength; y++)
            {
                temp += lines[y][x];
            }
            words.Add(temp);
        }
        for (int y = 0; y < yLength; y++)
        {
            for (int x = 0; x < xLength; x++)
            {
                if (!crawledDownRight.Contains((x, y))) words.Add(crawlDownRight(lines, x, y, xLength, yLength, crawledDownRight));
                if (!crawledUpRight.Contains((x, y))) words.Add(crawlUpRight(lines, x, y, xLength, yLength, crawledUpRight));
            }
        }
        var sum = words.Select(w => Xmassamx().Count(w)).Sum();
        return Task.FromResult($"{sum}");
    }

    private string crawlDownRight(string[] lines, int xStart, int yStart, int maxX, int maxY, HashSet<(int x, int y)> crawledDownRight)
    {
        string left = "", right = "";
        int x = xStart, y = yStart;
        while (x < maxX && y < maxY)
        {
            crawledDownRight.Add((x, y));
            right += lines[y++][x++];
        }
        x = xStart;
        y = yStart;
        while (x >= 0 && y >= 0)
        {
            crawledDownRight.Add((x, y));
            left += lines[y--][x--];
        }
        char[] charArray = left[1..].ToCharArray();
        Array.Reverse(charArray);
        return $"{new string(charArray) + right}";
    }

    private string crawlUpRight(string[] lines, int xStart, int yStart, int maxX, int maxY, HashSet<(int x, int y)> crawledUpRight)
    {
        string left = "", right = "";
        int x = xStart, y = yStart;
        while (x < maxX && y >= 0)
        {
            crawledUpRight.Add((x, y));
            right += lines[y--][x++];
        }
        x = xStart;
        y = yStart;
        while (x >= 0 && y < maxY)
        {
            crawledUpRight.Add((x, y));
            left += lines[y++][x--];
        }
        char[] charArray = left[1..].ToCharArray();
        Array.Reverse(charArray);
        return $"{new string(charArray) + right}";
    }

    [GeneratedRegex(@"(?=XMAS|SAMX)")]
    private static partial Regex Xmassamx();
}

public class TestPart1() : Part1("Days/_04/test1.txt")
{

}
