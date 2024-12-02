using aoc2K24.Helpers;
using System.Diagnostics;

namespace aoc2K24;
public class AbstractSolver(string filePath) : ISolver
{
    public async Task<(string result, double elapsed)> Result()
    {
        var lines = await filePath.FromFilePathAsArray();
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        var result = await Run(lines);
        stopWatch.Stop();
        return (result, stopWatch.Elapsed.TotalMilliseconds);
    }

    public virtual Task<string> Run(string[] lines) => Task.FromResult("");
}
