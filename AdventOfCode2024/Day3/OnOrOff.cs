namespace Day3
{
    internal class OnOrOff
    {
        private readonly List<int> dos;
        private readonly List<int> donts;

        public OnOrOff(string input) 
        { 
            this.dos = FindDos(input);
            this.donts = FindDonts(input);
        }

        public bool IsOn(int index)
        { 
            var latestDo = dos.Where(x => x <= index).Max();
            var latestDonts = donts.Where(x => x <= index);
            if (latestDonts.Any())
            {
                return latestDo > latestDonts.Max();
            }

            return true;           
        }

        private List<int> FindDos(string input)
        {
            var result = new List<int>
            {
                0
            };
            var currentIndex = 0;

            while (currentIndex < input.Length)
            {
                var index = input.IndexOf("do()", currentIndex);
                if (index >= 0)
                {
                    result.Add(index);
                    currentIndex = index + 4;
                }
                else
                {
                    currentIndex = input.Length;
                }
            }

            return result;
        }

        private List<int> FindDonts(string input)
        {
            var result = new List<int>();
            var currentIndex = 0;

            while (currentIndex < input.Length)
            {
                var index = input.IndexOf("don't()", currentIndex);
                if (index >= 0)
                {
                    result.Add(index);
                    currentIndex = index + 6;
                }
                else
                {
                    currentIndex = input.Length;
                }
            }

            return result;
        }
    }
}
