namespace aoc2K24.Helpers;
public static class FileHelper
{
    public static async Task<string> FromFilePath(this string path)
        => await File.ReadAllTextAsync(path);

    public static async Task<string[]> FromFilePathAsArray(this string path, char split = '\n')
    {
        return (await path.FromFilePath()).Split(split);
    }
}
