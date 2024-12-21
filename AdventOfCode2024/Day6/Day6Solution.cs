using Common;
using System.Diagnostics.Metrics;

namespace Day6;

public class Day6Solution : ISolution
{
    public long SolvePart1(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var path = new Path(lines);

        return path.FindPathLength();
    }

    public long SolvePart2(string input)
    {
        throw new NotImplementedException();
    }
}
