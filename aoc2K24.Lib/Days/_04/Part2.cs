﻿using System.Globalization;
using System.Text.RegularExpressions;

namespace aoc2K24.Days._04;

public partial class Part2(string filePath) : AbstractSolver(filePath)
{
    public Part2() : this("Days/_04/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        return Task.FromResult($"");
    }
}

public class TestPart2() : Part2("Days/_04/test2.txt")
{

}