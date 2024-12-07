using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Report
    {
        private readonly int[] levels;

        private Report(params int[] levels)
        {
            this.levels = levels;
        }

        public bool IsSafe
        {
            get
            {
                var deltas = levels
                    .Select((x, index) => (int?)(index < levels.Length - 1 ? x - levels[index + 1] : null))
                    .Where(x => x.HasValue)
                    .Select(x => x.Value);

                if (deltas.All(x => x < 0) || deltas.All(x => x > 0))
                {
                    return deltas.All(x => Math.Abs(x) < 4); 
                }

                return false;
            }
        }

        public static Report Create(string report)
        { 
            var levels = report.Split(' ').Select(x => int.Parse(x));
            return new Report(levels.ToArray());
        }
    }
}
