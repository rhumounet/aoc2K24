using System.Globalization;
using System.Text.RegularExpressions;

namespace aoc2K24.Days._05;

public partial class Part2(string filePath) : AbstractSolver(filePath)
{
    public Part2() : this("Days/_05/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        return Task.FromResult($"");
    }
}

public class TestPart2() : Part2("Days/_05/test2.txt")
{

}
