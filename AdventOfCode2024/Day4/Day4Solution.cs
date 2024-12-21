using Common;

namespace Day4;

public class Day4Solution : ISolution
{
    public long SolvePart1(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var point = new Point(lines[0].Length, lines.Length);

        long count = 0;
        while (point.Valid)
        {
            count += XmasInstances(point, lines);
            point = point.Next;
        }

        return count;
    }

    private int XmasInstances(Point point, string[] lines)
    {
        if (lines[point.Row][point.Column] != 'X')
        {
            return 0;
        }

        var directions = new List<Func<Point, Point>>
        {
            p => p.North,
            p => p.South,
            p => p.East,
            p => p.West,
            p => p.SouthWest,
            p => p.SouthEast,
            p => p.NorthWest,
            p =>p.NorthEast
        };

        int count = 0;
        foreach (var direction in directions)
        {
            var currentPoint = direction(point);
            if (!LetterMatches(currentPoint, 'M', lines))
            {
                continue;
            }

            currentPoint = direction(currentPoint);
            if (!LetterMatches(currentPoint, 'A', lines))
            {
                continue;
            }

            currentPoint = direction(currentPoint);
            if (LetterMatches(currentPoint, 'S', lines))
            {
                count++;
            }
        }

        return count;
    }

    private bool LetterMatches(Point point, char letter, string[] lines)
    { 
        return point.Valid && lines[point.Row][point.Column] == letter;
    }

    public long SolvePart2(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var point = new Point(lines[0].Length, lines.Length);

        long count = 0;
        while (point.Valid)
        {
            if (IsXmasInstance(point, lines))
            {
                count++;
            }

            point = point.Next;
        }

        return count;
    }

    private bool IsXmasInstance(Point point, string[] lines)
    {
        if (!LetterMatches(point, 'A', lines))
        {
            return false;
        }

        var nwSeMatch1 = LetterMatches(point.NorthWest, 'M', lines) && LetterMatches(point.SouthEast, 'S', lines);
        var nwSeMatch2 = LetterMatches(point.NorthWest, 'S', lines) && LetterMatches(point.SouthEast, 'M', lines);

        if (!(nwSeMatch1 || nwSeMatch2))
        {
            return false;
        }

        var neSwMatch1 = LetterMatches(point.NorthEast, 'M', lines) && LetterMatches(point.SouthWest, 'S', lines);
        var neSwMatch2 = LetterMatches(point.NorthEast, 'S', lines) && LetterMatches(point.SouthWest, 'M', lines);

        return neSwMatch1 || neSwMatch2;
    }
}
