namespace aoc2K24.Helpers;
public static class FileHelper
{
    public static async Task<string> FromFilePath(this string path)
        => await File.ReadAllTextAsync(path);

    public static async Task<string[]> FromFilePathAsArray(this string path, string split = "\r\n")
    {
        return (await path.FromFilePath())
            .Replace("\r\n", Environment.NewLine)
            .Replace("\n", Environment.NewLine)
            .Split(Environment.NewLine);
    }
}
