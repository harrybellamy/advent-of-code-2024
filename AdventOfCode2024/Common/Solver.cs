namespace Common
{
    public class Solver(ISolution solution)
    {
        private readonly FileLoader fileLoader = new();
        private readonly ISolution solution = solution;

        public long SolvePart1()
        {
            var input = fileLoader.LoadInput();

            var result = solution.SolvePart1(input);

            return result;
        }

        public long SolvePart2()
        {
            var input = fileLoader.LoadInput();

            var result = solution.SolvePart2(input);

            return result;
        }
    }
}
