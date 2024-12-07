using Common;

namespace Day2
{
    public class Day2Solution : ISolution
    {
        public long SolvePart1(string input)
        {
            var reports = new List<Report>();

            foreach (var line in input.Split(Environment.NewLine))
            { 
                reports.Add(Report.Create(line));
            }

            return reports.Count(report => report.IsSafe);
        }

        public long SolvePart2(string input)
        {
            throw new NotImplementedException();
        }
    }
}
