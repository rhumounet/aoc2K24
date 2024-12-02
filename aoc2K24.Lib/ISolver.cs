namespace aoc2K24;
public interface ISolver
{
    Task<(string result, double elapsed)> Result();
}
