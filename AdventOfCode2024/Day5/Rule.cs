using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Rule(int before, int after)
    {
        public int Before { get; } = before;
        public int After { get; } = after;

        public static Rule Parse(string line)
        {
            var tokens = line.Split('|');
            return new Rule(int.Parse(tokens[0]), int.Parse(tokens[1]));
        }
    }
}
