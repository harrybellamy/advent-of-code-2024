namespace Day1
{
    public class Day1Solution
    {
        public long SolvePart1(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var leftList = new List<int>();
            var rightList = new List<int>();

            foreach(var line in lines) 
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

            var orderedRightList = rightList.OrderBy(x => x).ToList();
            return leftList
                .OrderBy(x => x)
                .Select((item, index) => (long)Math.Abs(orderedRightList[index] - item))
                .Sum();
        }
    }
}
