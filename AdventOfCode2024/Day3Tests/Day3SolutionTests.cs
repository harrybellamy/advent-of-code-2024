using Common;
using Day3;

namespace Day3Tests;

public class Day3SolutionTests
{
    [Fact]
    public void Part1ExampleTest()
    {
        var input = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";
        var day3Solution = new Day3Solution();

        var result = day3Solution.SolvePart1(input);

        Assert.Equal(161, result);
    }

    [Fact]
    public void Part1AnswerTest()
    {
        var solution = new Day3Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart1();

        Assert.Equal(11, result);
    }

    [Fact]
    public void Part2ExampleTest()
    {
        var input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";
        var day1Solution = new Day3Solution();

        var result = day1Solution.SolvePart2(input);

        Assert.Equal(48, result);
    }

    [Fact]
    public void Part2AnswerTest()
    {
        var solution = new Day3Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart2();

        Assert.Equal(11, result);
    }
}