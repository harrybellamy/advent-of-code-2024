using Common;

namespace Day2
{
    public class Day2Solution : ISolution
    {
        private static IEnumerable<Report> GetReports(string input)
        {
            var reports = new List<Report>();

            foreach (var line in input.Split(Environment.NewLine))
            {
                reports.Add(Report.Create(line));
            }

            return reports;
        }

        public long SolvePart1(string input)
        {
            var reports = GetReports(input);

            return reports.Count(report => report.IsSafe);
        }

        public long SolvePart2(string input)
        {
            var reports = GetReports(input);

            return reports.Count(report => report.IsSafePart2);
        }
    }
}
