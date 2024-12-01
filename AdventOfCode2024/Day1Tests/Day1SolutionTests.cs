using Day1;

namespace Day1Tests
{
    public class Day1SolutionTests
    {
        private readonly string input = "3   4\r\n" +
            "4   3\r\n" +
            "2   5\r\n" +
            "1   3\r\n" +
            "3   9\r\n" +
            "3   3\r\n";

        [Fact]
        public void Part1ExampleTest()
        {
            var day1Solution = new Day1Solution();

            var result = day1Solution.SolvePart1(input);

            Assert.Equal(11, result);
        }

        [Fact]
        public void Part1AnswerTest()
        {
            var solver = new Solver();

            var result = solver.SolvePart1();

            Assert.Equal(11, result);
        }

        [Fact]
        public void Part2ExampleTest()
        {
            var day1Solution = new Day1Solution();

            var result = day1Solution.SolvePart2(input);

            Assert.Equal(31, result);
        }

        [Fact]
        public void Part2AnswerTest()
        {
            var solver = new Solver();

            var result = solver.SolvePart2();

            Assert.Equal(11, result);
        }
    }
}