using System.Text.RegularExpressions;
namespace aoc2K24.Days._05;

public partial class Part1(string filePath) : AbstractSolver(filePath)
{
    public Part1() : this("Days/_05/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        return Task.FromResult($"");
    }
}

public class TestPart1() : Part1("Days/_05/test1.txt")
{

}
