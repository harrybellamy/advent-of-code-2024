using Common;
using Day2;

namespace Day2Tests
{
    public class Day2SolutionTests
    {
        [Fact]
        public void Part1AnswerTest()
        {
            var solution = new Day2Solution();
            var solver = new Solver(solution);

            var result = solver.SolvePart1();

            Assert.Equal(11, result);
        }

        [Fact]
        public void Part2AnswerTest()
        {
            var solution = new Day2Solution();
            var solver = new Solver(solution);

            var result = solver.SolvePart2();

            Assert.Equal(11, result);
        }
    }
}
