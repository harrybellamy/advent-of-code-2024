namespace Day1
{
    public class Day1Solution
    {
        private record InputLists(List<int> Left, List<int> Right);

        private InputLists ParseInputLists(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var leftList = new List<int>();
            var rightList = new List<int>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var numbers = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (numbers.Length != 2)
                {
                    throw new Exception($"An incorrect number of numbers was found on line '{line}' ({numbers})");
                }

                leftList.Add(int.Parse(numbers[0]));
                rightList.Add(int.Parse(numbers[1]));
            }

            return new InputLists(leftList, rightList);
        }

        public long SolvePart1(string input)
        {
            var (leftList, rightList) = ParseInputLists(input);

            var orderedRightList = rightList.OrderBy(x => x).ToList();
            return leftList
                .OrderBy(x => x)
                .Select((item, index) => (long)Math.Abs(orderedRightList[index] - item))
                .Sum();
        }

        public long SolvePart2(string input)
        {
            var (leftList, rightList) = ParseInputLists(input);

            var leftMultiSet = leftList.AsMultiSet();
            var rightMultiSet = rightList.AsMultiSet();

            long retval = 0;

            foreach (var item in leftMultiSet.UniqueItems)
            {
                retval += item * rightMultiSet.Count(item) * leftMultiSet.Count(item);
            }

            return retval;
        }
    }
}
