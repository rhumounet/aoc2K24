using System.Globalization;

namespace aoc2K24.Days._02;

public class Part2(string filePath) : AbstractSolver(filePath)
{
    public Part2() : this("Days/_02/data.txt") { }
    public override Task<string> Run(string[] lines)
    {
        static int valid(List<int> values, int sign)
        {
            for (int i = 0; i < values.Count - 1; i++)
            {
                var diff = values[i] - values[i + 1];
                var diffSign = Math.Sign(diff);
                if (Math.Abs(diff) <= 3 && diff != 0 && sign == diffSign)
                    continue;
                return 0;
            }
            return 1;
        }
        var safe = lines.Select(l =>
        {
            var values = l.Split(' ').Select(l => Convert.ToInt32(l, CultureInfo.InvariantCulture)).ToList();
            //BRUTEFORCE SA MERE PARCE QUE J'Y ARRIVE PAS
            int result = 0;
            for (int j = 0; j < values.Count; j++)
            {
                var temp = values.ToList();
                temp.RemoveAt(j);
                int sign = Math.Sign(temp[0] - temp[1]);
                result += valid(temp, sign);
            }
            return result != 0 ? 1 : 0;
        });
        return Task.FromResult($"{safe.Sum()}");
    }
}

public class TestPart2() : Part2("Days/_02/test.txt")
{

}
