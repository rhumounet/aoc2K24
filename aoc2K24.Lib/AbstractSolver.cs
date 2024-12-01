using aoc2K24.Helpers;

namespace aoc2K24;
internal class AbstractSolver(string filePath) : ISolver
{
    public async Task<string> Result()
    {
        var lines = await filePath.FromFilePathAsArray();
        return await Run(lines);
    }

    public virtual Task<string> Run(string[] lines) => Task.FromResult("");
}
