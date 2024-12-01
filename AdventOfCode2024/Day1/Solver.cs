namespace Day1
{
    public class Solver
    {
        private readonly FileLoader fileLoader = new();
        private readonly Day1Solution solution = new();

        public long SolvePart1()
        {
            var input = fileLoader.LoadInput();

            var result = solution.SolvePart1(input);

            return result;
        }
    }
}
