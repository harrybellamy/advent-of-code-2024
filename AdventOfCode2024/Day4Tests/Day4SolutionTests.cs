using Common;
using Day4;
using System.Runtime.ConstrainedExecution;

namespace Day4Tests;

public class Day4SolutionTests
{
    private readonly string exampleInput = """
        MMMSXXMASM
        MSAMXMSMSA
        AMXSXMAAMM
        MSAMASMSMX
        XMASAMXAMM
        XXAMMXXAMA
        SMSMSASXSS
        SAXAMASAAA
        MAMMMXMMMM
        MXMXAXMASX
        """;

    [Fact]
    public void Part1SingleLineTest()
    {
        var day4Solution = new Day4Solution();
        var result = day4Solution.SolvePart1("MMMSXXMASM");

        Assert.Equal(1, result);
    }

    [Fact]
    public void Part1ExampleTest()
    {
        var day4Solution = new Day4Solution();
        var result = day4Solution.SolvePart1(exampleInput);

        Assert.Equal(18, result);
    }

    [Fact]
    public void Part1AnswerTest()
    {
        var solution = new Day4Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart1();

        Assert.Equal(11, result);
    }

    [Fact]
    public void Part2SmallExampleTest()
    {
        var smallInput = """
            M.S
            .A.
            M.S
            """;

        var day4Solution = new Day4Solution();
        var result = day4Solution.SolvePart2(smallInput);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Part2ExampleTest()
    {
        var day4Solution = new Day4Solution();
        var result = day4Solution.SolvePart2(exampleInput);

        Assert.Equal(9, result);
    }

    [Fact]
    public void Part2AnswerTest()
    {
        var solution = new Day4Solution();
        var solver = new Solver(solution);

        var result = solver.SolvePart2();

        Assert.Equal(11, result);
    }
}