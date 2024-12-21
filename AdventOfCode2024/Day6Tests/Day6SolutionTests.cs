using Common;
using Day6;

namespace Day6Tests;

public class Day6SolutionTests
{
    private readonly string input = """
        ....#.....
        .........#
        ..........
        ..#.......
        .......#..
        ..........
        .#..^.....
        ........#.
        #.........
        ......#...
        """;

    [Fact]
    public void Part1ExampleTest()
    {
        var day6Solution = new Day6Solution();
        var result = day6Solution.SolvePart1(input);

        Assert.Equal(41, result);
    }

    [Fact]
    public void Part1AnswerTest()
    {
        var solution = new Day6Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart1();

        Assert.Equal(11, result);
    }
}