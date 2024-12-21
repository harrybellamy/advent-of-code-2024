using Common;
using Day5;

namespace Day5Tests;

public class Day5SolutionTests
{
    private readonly string input = """
        47|53
        97|13
        97|61
        97|47
        75|29
        61|13
        75|53
        29|13
        97|29
        53|29
        61|53
        97|53
        61|29
        47|13
        75|47
        97|75
        47|61
        75|61
        47|29
        75|13
        53|13

        75,47,61,53,29
        97,61,53,29,13
        75,29,13
        75,97,47,61,53
        61,13,29
        97,13,75,29,47
        """;

    [Fact]
    public void Part1ExampleTest()
    {
        var day5Solution = new Day5Solution();
        var result = day5Solution.SolvePart1(input);

        Assert.Equal(143, result);
    }

    [Fact]
    public void Part1AnswerTest()
    {
        var solution = new Day5Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart1();

        Assert.Equal(11, result);
    }

    [Fact]
    public void Part2ExampleTest()
    {
        var day5Solution = new Day5Solution();
        var result = day5Solution.SolvePart2(input);

        Assert.Equal(123, result);
    }

    [Fact]
    public void Part2AnswerTest()
    {
        var solution = new Day5Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart2();

        Assert.Equal(11, result);
    }
}