using Common;
using Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Tests
{
    public class Day1SolutionTests
    {
        [Fact]
        public void Part1AnswerTest()
        {
            var solution = new Day2Solution();
            var solver = new Solver(solution);

            var result = solver.SolvePart1();

            Assert.Equal(11, result);
        }
    }
}
