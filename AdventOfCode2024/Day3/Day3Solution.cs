using Common;

namespace Day3
{
    public class Day3Solution : ISolution
    {

        public long SolvePart1(string input)
        {
            int currentIndex = 0;
            long retval = 0;
            while (currentIndex < input.Length)
            {
                var mulIndex = input.IndexOf("mul(", currentIndex);
                if (mulIndex < 0)
                {
                    break;
                }

                var instructionLength = Math.Min(8, input.Length - (mulIndex + 4));
                var instruction = input.Substring(mulIndex + 4, instructionLength);
                var bracketIndex = instruction.IndexOf(')');

                if (bracketIndex < 0)
                {
                    currentIndex += 4;
                    continue;
                }

                var values = instruction.Substring(0, bracketIndex).Split(',');
                if (int.TryParse(values[0], out int left) && int.TryParse(values[1], out int right))
                {
                    retval += left * right;
                }

                currentIndex = mulIndex + instructionLength;
            }

            return retval;
        }

        public long SolvePart2(string input)
        {
            int currentIndex = 0;
            long retval = 0;
            var onOrOff = new OnOrOff(input);

            while (currentIndex < input.Length)
            {
                var mulIndex = input.IndexOf("mul(", currentIndex);
                if (mulIndex < 0)
                {
                    break;
                }

                var instructionLength = Math.Min(8, input.Length - (mulIndex + 4));
                var instruction = input.Substring(mulIndex + 4, instructionLength);
                var bracketIndex = instruction.IndexOf(')');

                if (bracketIndex < 0 || !onOrOff.IsOn(mulIndex))
                {
                    currentIndex += 4;
                    continue;
                }

                var values = instruction.Substring(0, bracketIndex).Split(',');
                if (int.TryParse(values[0], out int left) && int.TryParse(values[1], out int right))
                {
                    retval += left * right;
                }

                currentIndex = mulIndex + instructionLength;
            }

            return retval;
        }
    }
}
